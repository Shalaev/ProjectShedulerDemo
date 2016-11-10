using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShedulerDemo.Models
{
    /// <summary>
    /// A finish-to-start dependency between tasks.
    /// </summary>
    public class TaskDependency
    {
        /// <summary>
        /// The predecessor task.
        /// </summary>
        public Task Source { get; set; }

        /// <summary>
        /// The successor task.
        /// </summary>
        public Task Destination { get; set; }

        public override string ToString()
        {
            return String.Format("{0} -> {1}", (Source ?? Task.Invalid).ID, (Destination ?? Task.Invalid).ID);
        }
    }
}
