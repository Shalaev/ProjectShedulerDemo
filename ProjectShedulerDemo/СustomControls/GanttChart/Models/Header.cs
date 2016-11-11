using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShedulerDemo.СustomControls.GanttChart.Models
{
    class Header
    {
        private string _headerText;
        private int _startLocation;
        private string _headerTextInsteadOfTime;
        private DateTime _time;

        public string HeaderText
        {
            get { return _headerText; }
            set { _headerText = value; }
        }

        public int StartLocation
        {
            get { return _startLocation; }
            set { _startLocation = value; }
        }

        public string HeaderTextInsteadOfTime
        {
            get { return _headerTextInsteadOfTime; }
            set { _headerTextInsteadOfTime = value; }
        }

        public DateTime Time
        {
            get { return _time; }
            set { _time = value; }
        }
    }
}
