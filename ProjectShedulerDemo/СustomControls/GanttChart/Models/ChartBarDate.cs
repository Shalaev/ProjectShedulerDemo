using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShedulerDemo.СustomControls.GanttChart.Models
{
    class ChartBarDate
    {
        internal class Location
        {

            private Point _right = new Point(0, 0);

            private Point _left = new Point(0, 0);
            public Point Right
            {
                get { return _right; }
                set { _right = value; }
            }

            public Point Left
            {
                get { return _left; }
                set { _left = value; }
            }
        }

        private DateTime _startValue;

        private DateTime _endValue;
        private Color _color;

        private Color _hoverColor;
        private string _text;

        private object _value;

        private int _rowIndex;
        private Location _topLocation = new Location();

        private Location _bottomLocation = new Location();

        private bool _hideFromMouseMove = false;

        public DateTime StartValue
        {
            get { return _startValue; }
            set { _startValue = value; }
        }

        public DateTime EndValue
        {
            get { return _endValue; }
            set { _endValue = value; }
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

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public object Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public int RowIndex
        {
            get { return _rowIndex; }
            set { _rowIndex = value; }
        }

        public bool HideFromMouseMove
        {
            get { return _hideFromMouseMove; }
            set { _hideFromMouseMove = value; }
        }

        internal Location TopLocation
        {
            get { return _topLocation; }
            set { _topLocation = value; }
        }

        internal Location BottomLocation
        {
            get { return _bottomLocation; }
            set { _bottomLocation = value; }
        }
    }
}
