using ProjectShedulerDemo.Models;
using ProjectShedulerDemo.Optimizer;
using ProjectShedulerDemo.Utilities;
using ProjectShedulerDemo.СustomControls.GanttChart;
using ProjectShedulerDemo.СustomControls.GanttChart.Models;
using ProjectShedulerDemo.СustomControls.GanttLegend;
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
        Project project = null;
        SchedulingModel schedulingModel = null;
        IDictionary<int, double> schedule = null;

        public MainForm()
        {
            tasksGanttChart = new GanttChart();
            schedulingModel = new SchedulingModel(false);
            InitializeComponent();
            InitializeGantChart();
            InitializeProject();
            SolveShedule();
            ShowGantChart();
        }

        public void ShowGantChart()
        {
            tasksGanttChart.ClearChartBars();
            var ganttData = ProjectUtilities.ganttFormat(project, schedule);
            var gantLegends = ganttData.GroupBy(gd => gd.BarName).Select(gd => gd.First());
            foreach(var gantLegend in gantLegends)
            {
                gantChartContainer.Panel1.Controls.Add(new GanttLegent(gantLegend.Color, gantLegend.BarName) { Dock = DockStyle.Left});
            }
            foreach (BarInformation bar in ganttData)
            {
                tasksGanttChart.AddChartBar(bar.RowText, bar, bar.FromTime, bar.ToTime, bar.Color, bar.HoverColor, bar.Index);
            }
        }

        private void SolveShedule()
        {
            schedulingModel.Initialize(project);
            schedule = schedulingModel.Solve();

            console.AppendText(ProjectUtilities.PrintProjectSchedule(project, schedule));
            String result = ProjectUtilities.ToCsv(project, schedule);
            console.AppendText(result);
        }

        private void InitializeProject()
        {
            project = ProjectUtilities.CreateProject(7, 3);

            console.AppendText(project.ToString());
        }

        private void InitializeGantChart()
        {
            tasksGanttChart.AllowChange = false;
            tasksGanttChart.Dock = DockStyle.Fill;
            tasksGanttChart.FromDate = DateTime.Now;
            tasksGanttChart.ToDate = DateTime.Now.AddDays(30);
            gantChartContainer.Panel2.Controls.Add(tasksGanttChart);

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
