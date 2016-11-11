using Microsoft.SolverFoundation.Services;
using ProjectShedulerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShedulerDemo.Optimizer
{
    /// <summary>
    /// A Solver Foundation model for solving resource constrained project scheduling problems.
    /// </summary>
    /// <remarks>
    /// This model produces a schedule with minimum duration with no overallocations.
    /// </remarks>
    public class SchedulingModel
    {
        private bool verbose;
        private SolverContext context;
        private Model model;
        private Set tasks, events, events1ToN; // in the paper: sets A, R, E, and E - 0.
        private Decision makespan; // C_max
        private Decision isActive; // z
        private Decision start; // t
        private Parameter duration; // p

        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="verbose">Indicates whether to dump intermediate output.</param>
        public SchedulingModel(bool verbose)
        {
            this.verbose = verbose;
        }

        /// <summary>
        /// Create the model.
        /// </summary>
        /// <param name="project">The project to be scheduled.</param>
        public void Initialize(Project project)
        {
            context = SolverContext.GetContext();
            context.ClearModel();
            model = context.CreateModel();

            int eventCount = project.Tasks.Count;

            // we will fill these in in the remainder of the post.
            InitializeSets(project.Tasks.Count, eventCount, project.Resources.Count);
            InitializeParameters(project.Tasks, project.Resources);
            InitializeDecisions();
            InitializeGoal();
            InitializeConstraints(project, eventCount);
        }

        private void InitializeSets(int taskCount, int eventCount, int resourceCount)
        {
            tasks = new Set(Domain.Real, "tasks");
            events = new Set(0, eventCount, 1);
            events1ToN = new Set(1, eventCount, 1); // starting from event 1.
        }

        private void InitializeParameters(ICollection<Models.Task> t, ICollection<Resource> r)
        {
            duration = new Parameter(Domain.RealNonnegative, "duration", tasks);
            duration.SetBinding(t, "Duration", "ID");
            model.AddParameters(duration);
        }
        private void InitializeDecisions()
        {
            makespan = new Decision(Domain.RealNonnegative, "makespan");
            isActive = new Decision(Domain.IntegerRange(0, 1), "isActive", tasks, events);
            start = new Decision(Domain.RealNonnegative, "start", events);
            model.AddDecisions(makespan, isActive, start);
        }

        private void InitializeGoal()
        {
            Goal goal = model.AddGoal("goal", GoalKind.Minimize, makespan); // (34)
        }

        private void InitializeConstraints(Project project, int eventCount)
        {
            // Establish the makespan: the maximum finish time over all activities.
            model.AddConstraint("c35",
              Model.ForEach(events1ToN, e =>
                Model.ForEach(tasks, i =>
                  makespan >= start[e] + (isActive[i, e] - isActive[i, e - 1]) * duration[i]
            )));

            // The first event starts at time 0.
            model.AddConstraint("c_36", start[0] == 0);

            // Link the isActive decision to the starts of each event and task durations.
            model.AddConstraint("c_37",
              Model.ForEach(events1ToN, e =>
                Model.ForEachWhere(events, f =>
                  Model.ForEach(tasks, i =>
                    start[f] >= start[e] + ((isActive[i, e] - isActive[i, e - 1]) - (isActive[i, f] - isActive[i, f - 1]) - 1) * duration[i]
                    ), f => f > e)));

            // Link the isActive decision with the first event. This constraint is missing in the original paper.
            model.AddConstraint("c_37_e0",
              Model.ForEach(events1ToN, f =>
                Model.ForEach(tasks, i =>
                  start[f] >= start[0] + (isActive[i, 0] - (isActive[i, f] - isActive[i, f - 1]) - 1) * duration[i]
              )));

            // Order the events.
            model.AddConstraint("c_38", Model.ForEach(events1ToN, e => start[e] >= start[e - 1]));

            // Ensure adjacency of events for an in-progress task.
            SumTermBuilder sum = new SumTermBuilder(eventCount);
            for (int i = 0; i < project.Tasks.Count; i++)
            {
                for (int e = 1; e < eventCount; e++)
                {
                    sum.Add(isActive[i, e - 1]);
                    model.AddConstraint("c_39_" + i + "_" + e,
                      sum.ToTerm() <= e * (1 - (isActive[i, e] - isActive[i, e - 1])));
                }
                sum.Clear();
            }

            sum = new SumTermBuilder(eventCount);
            for (int i = 0; i < project.Tasks.Count; i++)
            {
                for (int e = 1; e < eventCount; e++)
                {
                    for (int e1 = e; e1 < eventCount; e1++)
                    {
                        sum.Add(isActive[i, e1]); // (it's inefficient to reconstruct this for each value of e.)
                    }
                    model.AddConstraint("c_40_" + i + "_" + e,
                      sum.ToTerm() <= e * (1 + (isActive[i, e] - isActive[i, e - 1])));
                    sum.Clear();
                }
            }

            // All activities must be active during the project.
            model.AddConstraint("c_41", Model.ForEach(tasks, i =>
              Model.Sum(Model.ForEach(events, e => isActive[i, e])) >= 1));

            // A link (i, j) means that the start of task j must be after the finish of task i.
            int c42 = 0;
            foreach (TaskDependency link in project.Dependencies)
            {
                int i = link.Source.ID;
                int j = link.Destination.ID;
                sum = new SumTermBuilder(eventCount);
                for (int e = 0; e < eventCount; e++)
                {
                    sum.Add(isActive[j, e]); // sum now has isActive[j, 0] .. isActive[j, e].
                    model.AddConstraint("c_42_" + c42++, isActive[i, e] + sum.ToTerm() <= 1 + e * (1 - isActive[i, e]));
                }
            }

            // Resource usage during each event must not exceed resource capacity.
            Dictionary<Resource, int> resToId = new Dictionary<Resource, int>(project.Resources.Count);
            for (int k = 0; k < project.Resources.Count; k++)
            {
                resToId[project.Resources[k]] = k;
            }
            SumTermBuilder[] totalResWork = new SumTermBuilder[project.Resources.Count];
            int c43 = 0;
            for (int e = 0; e < eventCount; e++)
            {
                for (int taskID = 0; taskID < project.Tasks.Count; taskID++)
                {
                    foreach (var assn in project.Tasks[taskID].Assignments)
                    {
                        int resID = resToId[assn.Resource];
                        if (totalResWork[resID] == null)
                        {
                            totalResWork[resID] = new SumTermBuilder(4); // most tasks will have <= 4 assignments.
                        }
                        totalResWork[resID].Add(assn.Units * isActive[taskID, e]);
                    }
                }

                for (int resID = 0; resID < totalResWork.Length; resID++)
                {
                    if (totalResWork[resID] != null)
                    {
                        model.AddConstraint("c43_" + c43++, totalResWork[resID].ToTerm() <= project.Resources[resID].MaxUnits);
                        totalResWork[resID] = null; // note: memory churn...
                    }
                }
            }
        }

        /// <summary>
        /// Solve the model.
        /// </summary>
        public IDictionary<int, double> Solve()
        {
            //GurobiDirective directive = new GurobiDirective();
            //directive.OutputFlag = verbose;
            SimplexDirective directive = new SimplexDirective();
            var solution = context.Solve(directive);
            if (verbose)
            {
                Console.WriteLine(solution.GetReport());
            }

            return GetStartTimesByTask();
        }

        private IDictionary<int, double> GetStartTimesByTask()
        {
            // The "start" decision has the start times for each *event*. Index 0 has the start and index 1 has the event.
            // Recall that the event set was created using Rationals, so we must convert to int here.
            var eventToStart1 = start.GetValues();
            var eventToStart = start.GetValues().ToDictionary(o => o[1], o => (double)o[0]);

            // Group the isActive decision by task.
            var isActiveByTask = isActive.GetValues().GroupBy(o => o[1]);

            // Find the first event where each task is active, and transform the output into (task, event) pairs.
            var firstActiveByTask = isActiveByTask
              .Select(g => g.First(a => (double)a[0] > 0.5))
              .Select(o => new { TaskID = (int)((double)o[1]), EventID = o[2] });

            // Now we can use the (task, event) pairs to get a dictionary that maps task IDs to start dates.
            return firstActiveByTask.ToDictionary(f => f.TaskID, f => eventToStart[f.EventID]);
        }
    }
}
