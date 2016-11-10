using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShedulerDemo.Models
{
    /// <summary>
    /// A resource.
    /// </summary>
    /// <remarks>
    /// A resource may correspond to a work resource (such as an employee),
    /// or a material resource (such as a machine).
    /// </remarks>
    public class Resource
    {
        private static int nextID = 0;

        /// <summary>
        /// A unique ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>The resource name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The maximum rate at which the resource can perform work.
        /// </summary>
        public double MaxUnits { get; set; }

        public Resource(string name, double maxUnits)
        {
            ID = nextID++;
            Name = name;
            MaxUnits = maxUnits;
        }

        public override string ToString()
        {
            return String.Format("{0}: {1} max units = {2}", ID, Name, MaxUnits);
        }
    }
}
