using ProjectShedulerDemo.Models;
using ProjectShedulerDemo.Optimizer;
using ProjectShedulerDemo.Utilities;
using ProjectShedulerDemo.СustomControls.GanttChart;
using ProjectShedulerDemo.СustomControls.GanttChart.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectShedulerDemo
{
    public partial class MainForm : Form
    {
        GanttChart tasksGanttChart = null;

        public MainForm()
        {
            InitializeComponent();
            InitializeGantChart();
            Project project = ProjectUtilities.CreateProject(6, 1);
            console.AppendText(project.ToString());
            Stopwatch stopwatch = new Stopwatch();
            SchedulingModel m = new SchedulingModel(false);

            stopwatch.Start();
            m.Initialize(project);
            console.AppendText("Init time = " + stopwatch.Elapsed + "\r\n");
            IDictionary<int, double> schedule = m.Solve();
            console.AppendText("Total time = " + stopwatch.Elapsed + "\r\n");

            ProjectUtilities.PrintProjectSchedule(project, schedule);
            String result = ProjectUtilities.ToCsv(project, schedule);

            var ganttData = ProjectUtilities.ganttFormat(project, schedule);
            foreach (BarInformation bar in ganttData)
            {
                tasksGanttChart.AddChartBar(bar.RowText, bar, bar.FromTime, bar.ToTime, bar.Color, bar.HoverColor, bar.Index);
            }
            //File.WriteAllText("D:\\result.csv", result);
            //console.AppendText(result);
        }

        private void InitializeGantChart()
        {
            tasksGanttChart = new GanttChart();
            tasksGanttChart.AllowChange = false;
            tasksGanttChart.Dock = DockStyle.Fill;
            tasksGanttChart.FromDate = DateTime.Now;
            tasksGanttChart.ToDate = DateTime.Now.AddDays(30);
            splitContainer2.Panel2.Controls.Add(tasksGanttChart);

            tasksGanttChart.MouseMove += new MouseEventHandler(tasksGanttChart.GanttChart_MouseMove);
            tasksGanttChart.MouseMove += new MouseEventHandler(GanttChart1_MouseMove);
            tasksGanttChart.MouseDragged += new MouseEventHandler(tasksGanttChart.GanttChart_MouseDragged);
            tasksGanttChart.MouseLeave += new EventHandler(tasksGanttChart.GanttChart_MouseLeave);
        }

        private void GanttChart1_MouseMove(Object sender, MouseEventArgs e)
        {
            List<string> toolTipText = new List<string>();

            if (tasksGanttChart.MouseOverRowText.Length > 0)
            {
                BarInformation val = (BarInformation)tasksGanttChart.MouseOverRowValue;
                toolTipText.Add("[b]Date:");
                toolTipText.Add("From ");
                toolTipText.Add(val.FromTime.ToLongDateString() + " - " + val.FromTime.ToString("HH:mm"));
                toolTipText.Add("To ");
                toolTipText.Add(val.ToTime.ToLongDateString() + " - " + val.ToTime.ToString("HH:mm"));
            }
            else
            {
                toolTipText.Add("");
            }

            tasksGanttChart.ToolTipTextTitle = tasksGanttChart.MouseOverRowText;
            tasksGanttChart.ToolTipText = toolTipText;

        }
    }
}
