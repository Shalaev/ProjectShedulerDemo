using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShedulerDemo.Models
{
    /// <summary>
    /// An assignment, corresponding to a task and a resource.
    /// </summary>
    public class Assignment
    {
        /// <summary>
        /// The resource.
        /// </summary>
        public Resource Resource { get; set; }

        /// <summary>
        /// The rate at which work is performed.
        /// </summary>
        public double Units { get; set; }

        public Assignment(Resource resource, double units)
        {
            Resource = resource;
            Units = units;
        }

        public override string ToString()
        {
            return String.Format("r{0}: units = {1}", Resource.ID, Units);
        }
    }
}
