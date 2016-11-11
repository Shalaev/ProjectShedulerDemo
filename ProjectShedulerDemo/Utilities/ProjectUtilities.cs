using ProjectShedulerDemo.Models;
using ProjectShedulerDemo.СustomControls.GanttChart.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShedulerDemo.Utilities
{
    class ProjectUtilities
    {
        public static Project CreateProject(int taskCount, int resourceCount)
        {
            System.Random random = new Random(0);
            int maxDuration = 5;
            int linkCount = Math.Max(taskCount / 5, 1);

            Resource[] resources = new Resource[resourceCount];
            for (int i = 0; i < resources.Length; i++)
            {
                resources[i] = new Resource("R" + i, 1.0);
            }

            Models.Task[] tasks = new Models.Task[taskCount];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = new Models.Task("t" + i, random.Next(1, maxDuration + 1), new Assignment[] { new Assignment(resources[i % resources.Length], 1.0) });
            }

            TaskDependency[] links = new TaskDependency[linkCount];
            for (int i = 0; i < links.Length; i++)
            {
                int source = random.Next(0, taskCount - 1);
                int dest = random.Next(source + 1, taskCount); // guaranteeing no cycles.
                links[i] = new TaskDependency { Source = tasks[source], Destination = tasks[dest] };
            }

            return new Project(tasks, resources, links);
        }

        public static void PrintProjectSchedule(Project project, IDictionary<int, double> schedule)
        {
            Console.WriteLine();
            Console.WriteLine("SCHEDULE:");
            foreach (var taskSchedule in schedule)
            {
                Models.Task task = project.Tasks[taskSchedule.Key];
                double start = Math.Round(taskSchedule.Value, 3);
                Console.WriteLine("{0}: [{1} - {2}]", task.ID, start, start + task.Duration);
            }
        }

        private static DateTime AddDays(DateTime start, double days, bool isStart)
        {
            while (days > 0)
            {
                if (days > 1)
                {
                    start = start.AddDays(1);
                    start = NextWorkingTime(start, false);
                    days -= 1.0;
                }
                else {
                    start = start.AddHours(9 * days);
                    if (start.TimeOfDay >= TimeSpan.FromHours(isStart ? 17 : 17.01))
                    {
                        TimeSpan duration = start.TimeOfDay - TimeSpan.FromHours(17);
                        start = NextWorkingTime(start, isStart).Add(duration);
                    }
                    days = 0;
                }
            }
            start = NextWorkingTime(start, isStart);
            return start;
        }

        private static DateTime NextWorkingTime(DateTime start, bool isStart)
        {
            if (start.TimeOfDay >= TimeSpan.FromHours(isStart ? 17 : 17.01))
            {
                start = start.Date.AddHours(24 + 8);
            }
            else if (start.Hour < 8)
            {
                start = start.Date.AddHours(8);
            }

            while (start.DayOfWeek == DayOfWeek.Saturday || start.DayOfWeek == DayOfWeek.Sunday)
            {
                start = start.AddDays(1);
            }
            return start;
        }

        public static string ToCsv(Project project, IDictionary<int, double> schedule)
        {
            DateTime projectStart = DateTime.Now;
            StringBuilder build = new StringBuilder(40 + project.Tasks.Count * 30);
            build.AppendLine("ID,Name,Duration,Start_Date,Finish_Date,Predecessors,Resource_Names");
            Dictionary<string, int[]> depMap = project.Dependencies
              .GroupBy(d => d.Destination.Name)
              .ToDictionary(g => g.Key, g => g.Select(d => d.Source.ID + 1).ToArray()); // need to add 1 for MS Project.
            foreach (Models.Task task in project.Tasks)
            {
                string predNames = "";
                int[] predIds = null;
                if (depMap.TryGetValue(task.Name, out predIds))
                {
                    predNames = "\"" + string.Join(",", predIds) + "\"";
                }
                string resourceNames = "\"" + string.Join(",", task.Assignments.Select(a => a.Resource.Name)) + "\"";
                double startDay = schedule[task.ID];
                DateTime start = AddDays(projectStart, startDay, true);
                DateTime finish = AddDays(start, task.Duration, false);
                build.AppendFormat("{0},{1},{2}d,{3},{4},{5},{6}", task.ID + 1, task.Name, task.Duration,
                  start, finish, predNames, resourceNames);
                build.AppendLine();
            }
            return build.ToString();
        }

        public static List<BarInformation> ganttFormat(Project project, IDictionary<int, double> schedule)
        {
            List<Color> colors = new List<Color>();
            colors.Add(Color.Red);
            colors.Add(Color.Green);
            colors.Add(Color.Blue);
            colors.Add(Color.Yellow);
            colors.Add(Color.Silver);
            colors.Add(Color.Plum);

            DateTime projectStart = DateTime.Now;
            Dictionary<string, int[]> depMap = project.Dependencies
              .GroupBy(d => d.Destination.Name)
              .ToDictionary(g => g.Key, g => g.Select(d => d.Source.ID + 1).ToArray());

            List<BarInformation> ganttData = new List<BarInformation>();
            foreach (Models.Task task in project.Tasks)
            {
                double startDay = schedule[task.ID];
                DateTime start = AddDays(projectStart, startDay, true);
                DateTime finish = AddDays(start, task.Duration, false);
                var resourceId =  task.Assignments.Select(a => a.Resource.ID).FirstOrDefault();
                ganttData.Add(new BarInformation(task.Name, start, finish, colors[resourceId], Color.Khaki, task.ID));
            }
            return ganttData;
        }

        public void Logger(String lines)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("D:\\log.txt", true);
            file.WriteLine(lines);
            file.Close();

        }

    }
}
