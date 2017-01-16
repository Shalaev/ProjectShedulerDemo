using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShedulerDemo.Models
{
    /// <summary>
    /// A task.
    /// </summary>
    public class Task
    {
        private IEnumerable<Assignment> assignments;
        private static int nextID = 0;

        private Task(int id, string name, double duration, IEnumerable<Assignment> assignments)
        {
            ID = id;
            Name = name;
            Duration = duration;
            this.assignments = assignments;
        }

        /// <summary>
        /// A dummy invalid task.
        /// </summary>
        public static Task Invalid = new Task(-1, "** INVALID **", -1, null);

        /// <summary>
        /// A unique ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The task name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The task duration (time unit unspecified).
        /// </summary>
        public double Duration { get; set; }

        /// <summary>
        /// The resource assignments for the task.
        /// </summary>
        public IEnumerable<Assignment> Assignments
        {
            get { return assignments; }
        }

        public Task(string name, double duration, IEnumerable<Assignment> assignments)
          : this(nextID++, name, duration, assignments)
        {
        }

        public override string ToString()
        {
            return String.Format("{0}: {1} duration = {2}", ID, Name, Duration);
        }
    }
}
