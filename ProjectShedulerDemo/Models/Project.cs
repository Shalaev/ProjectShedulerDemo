using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShedulerDemo.Models
{
    /// <summary>
    /// A project.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// The list of tasks in the project.
        /// </summary>
        public IList<Task> Tasks { get; private set; }

        /// <summary>
        /// The list of resources in the project.
        /// </summary>
        public IList<Resource> Resources { get; private set; }

        /// <summary>
        /// The list of task dependency links in the project.
        /// </summary>
        public IList<TaskDependency> Dependencies { get; private set; }

        public Project(IList<Task> tasks, IList<Resource> resources, IList<TaskDependency> links)
        {
            Tasks = tasks;
            Resources = resources;
            Dependencies = links;
        }

        public override string ToString()
        {
            StringBuilder build = new StringBuilder(40 + Tasks.Count * 20);
            build.AppendLine(new string('-', 40));
            build.AppendLine("PROJECT");
            build.AppendLine("TASKS");
            foreach (Task task in Tasks)
            {
                build.AppendLine(task.ToString());
            }
            build.AppendLine("LINKS");
            foreach (TaskDependency link in Dependencies)
            {
                build.AppendLine(link.ToString());
            }
            build.AppendLine("RESOURCES");
            foreach (Resource resource in Resources)
            {
                build.AppendLine(resource.ToString());
            }
            build.AppendLine(new string('-', 40));
            return build.ToString();
        }
    }
}
