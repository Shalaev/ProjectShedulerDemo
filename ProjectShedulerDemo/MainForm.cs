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
using System.Threading;
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
            //InitializeProject();
            //SolveShedule();
            //ShowGantChart();
        }

        public void ShowGantChart()
        {
            tasksGanttChart.ClearChartBars();
            var ganttData = ProjectUtilities.ganttFormat(project, schedule);
            var gantLegends = ganttData.GroupBy(gd => gd.BarName).Select(gd => gd.First());
            foreach(var gantLegend in gantLegends)
            {
                //gantChartContainer.Panel1.Controls.Add(new GanttLegent(gantLegend.Color, gantLegend.BarName) { Dock = DockStyle.Left});
                this.InvokeEx(form => form.gantChartContainer.Panel1.Controls.Add(new GanttLegent(gantLegend.Color, gantLegend.BarName) { Dock = DockStyle.Left }));
            }
            foreach (BarInformation bar in ganttData)
            {
                tasksGanttChart.AddChartBar(bar.RowText, bar, bar.FromTime, bar.ToTime, bar.Color, bar.HoverColor, bar.Index);
            }
        }

        private void SolveShedule()
        {
            this.InvokeEx(form => form.pictureBoxPreloader.Visible = true);
            schedulingModel.Initialize(project);
            schedule = schedulingModel.Solve();
            string solveLog = ProjectUtilities.PrintProjectSchedule(project, schedule);
            this.InvokeEx(form => form.console.AppendText(solveLog));
            string resultLog = ProjectUtilities.ToCsv(project, schedule);
            this.InvokeEx(form => form.console.AppendText(resultLog));
            this.InvokeEx(form => form.pictureBoxPreloader.Visible = false);
            ShowGantChart();
        }

        private void InitializeProject()
        {
            //project = ProjectUtilities.CreateProject(7, 3);

            //console.AppendText(project.ToString());
        }
        private void InitializeRandomProject()
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                string jsonstring = ProjectUtilities.toJson(project);
                ProjectUtilities.Save(jsonstring, saveFileDialog.FileName);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string jsonstring = ProjectUtilities.Load(openFileDialog.FileName);
                project = ProjectUtilities.toProject(jsonstring);
                console.AppendText(project.ToString());
                ShowProject();
            }
        }

        private void сalculateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThreadStart solveSheduleThreadStart = new ThreadStart(SolveShedule);
            Thread solveSheduleThread = new Thread(solveSheduleThreadStart);
            solveSheduleThread.Start();
            //SolveShedule();

            
        }

        private void randomProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeRandomProject();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void OnFrameChanged(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)(() => OnFrameChanged(sender, e)));
                return;
            }
            ImageAnimator.UpdateFrames();
            Invalidate(false);
        }

        private void ShowProject()
        {
            dataGridViewResources.ColumnCount = 2;
            dataGridViewResources.Columns[0].Name = "Id";
            dataGridViewResources.Columns[1].Name = "Name";
            foreach(Resource item in project.Resources)
            {
                dataGridViewResources.Rows.Add(new string[] { item.ID.ToString(), item.Name });
            }
            dataGridViewTasks.ColumnCount = 4;
            dataGridViewTasks.Columns[0].Name = "Id";
            dataGridViewTasks.Columns[1].Name = "Name";
            dataGridViewTasks.Columns[2].Name = "Duraction";
            dataGridViewTasks.Columns[3].Name = "ResourceId";
            foreach (Models.Task item in project.Tasks)
            {
                int resourceId = item.Assignments.ToArray<Assignment>()[0].Resource.ID;
                dataGridViewTasks.Rows.Add(new string[] { item.ID.ToString(), item.Name, item.Duration.ToString(), resourceId.ToString()});
            }
            dataGridViewLinks.ColumnCount = 2;
            dataGridViewLinks.Columns[0].Name = "Source";
            dataGridViewLinks.Columns[1].Name = "Destination";
            foreach (TaskDependency item in project.Dependencies)
            {
                dataGridViewLinks.Rows.Add(new string[] { item.Source.ID.ToString(), item.Destination.ID.ToString() });
            }
        }

    }
}
