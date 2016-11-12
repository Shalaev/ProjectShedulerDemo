using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectShedulerDemo.СustomControls.GanttLegend
{
    public partial class GanttLegent : UserControl
    {
        public Color LegendColor
        {
            get { return this.legendColor.BackColor; }
            set
            {
                this.legendColor.BackColor = value;
                this.legendColor.ForeColor = value;
            }
        }

        public string LegendText
        {
            get { return legendText.Text; }
            set { legendText.Text = value; }
        }

        public GanttLegent()
        {
            InitializeComponent();
        }

        public GanttLegent(Color legendColor, string legendText)
        {
            InitializeComponent();
            LegendColor = legendColor;
            LegendText = legendText;
        }
    }
}
