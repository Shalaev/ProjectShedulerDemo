using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShedulerDemo.СustomControls.GanttChart.Models
{
    class BarInformation
    {
        public string RowText { get; set; }

        public string BarName { get; set; }

        public DateTime FromTime { get; set; }

        public DateTime ToTime { get; set; }

        public Color Color { get; set; }

        public Color HoverColor { get; set; }

        public int Index{ get; set; }

        public BarInformation() {}

        public BarInformation(string rowText, string barName, DateTime fromTime, DateTime totime, Color color, Color hoverColor, int index)
        {
            RowText = rowText;
            BarName = barName;
            FromTime = fromTime;
            ToTime = totime;
            Color = color;
            HoverColor = hoverColor;
            Index = index;
        }
    }
}
