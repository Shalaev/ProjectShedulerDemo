using ProjectShedulerDemo.Models;
using ProjectShedulerDemo.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            Project project = ProjectUtilities.CreateProject(6, 2);
            console.AppendText(project.ToString());
        }
    }
}
