using ProjectShedulerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShedulerDemo.Utilities
{
    class ProjectUtilities
    {
        // (Replace this with code that creates a "real" project. This project is randomly generated.)
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
    }
}
