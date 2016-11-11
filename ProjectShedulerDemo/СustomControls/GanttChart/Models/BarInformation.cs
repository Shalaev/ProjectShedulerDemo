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
        private string _rowText;
        private DateTime _fromTime;
        private DateTime _toTime;
        private Color _color;
        private Color _hoverColor;
        private int _index;

        public string RowText
        {
            get { return _rowText; }
            set { _rowText = value; }
        }

        public DateTime FromTime
        {
            get { return _fromTime; }
            set { _fromTime = value; }
        }

        public DateTime ToTime
        {
            get { return _toTime; }
            set { _toTime = value; }
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public Color HoverColor
        {
            get { return _hoverColor; }
            set { _hoverColor = value; }
        }

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        public BarInformation()
        {
        }

        public BarInformation(string rowText, DateTime fromTime, DateTime totime, Color color, Color hoverColor, int index)
        {
            RowText = rowText;
            FromTime = fromTime;
            ToTime = totime;
            Color = color;
            HoverColor = hoverColor;
            Index = index;
        }
    }
}
