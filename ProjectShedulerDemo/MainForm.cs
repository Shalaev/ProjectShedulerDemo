using ProjectShedulerDemo.Models;
using ProjectShedulerDemo.Optimizer;
using ProjectShedulerDemo.Utilities;
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
        public MainForm()
        {
            InitializeComponent();
            Project project = ProjectUtilities.CreateProject(6, 3);
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
            //File.WriteAllText("D:\\result.csv", result);
            console.AppendText(result);
        }
    }
}
