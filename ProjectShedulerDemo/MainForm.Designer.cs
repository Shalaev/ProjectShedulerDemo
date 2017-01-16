namespace ProjectShedulerDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сalculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сalculateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tasks = new System.Windows.Forms.TabPage();
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.Links = new System.Windows.Forms.TabPage();
            this.dataGridViewLinks = new System.Windows.Forms.DataGridView();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.console = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chartsTabs = new System.Windows.Forms.TabControl();
            this.tabResources = new System.Windows.Forms.TabPage();
            this.gantChartContainer = new System.Windows.Forms.SplitContainer();
            this.pictureBoxPreloader = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.dataGridViewResources = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.Links.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinks)).BeginInit();
            this.tabLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.chartsTabs.SuspendLayout();
            this.tabResources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gantChartContainer)).BeginInit();
            this.gantChartContainer.Panel2.SuspendLayout();
            this.gantChartContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreloader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResources)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.сalculateToolStripMenuItem,
            this.generationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1039, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // сalculateToolStripMenuItem
            // 
            this.сalculateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сalculateToolStripMenuItem1});
            this.сalculateToolStripMenuItem.Name = "сalculateToolStripMenuItem";
            this.сalculateToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.сalculateToolStripMenuItem.Text = "Sheduling";
            // 
            // сalculateToolStripMenuItem1
            // 
            this.сalculateToolStripMenuItem1.Name = "сalculateToolStripMenuItem1";
            this.сalculateToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.сalculateToolStripMenuItem1.Text = "Сalculate";
            this.сalculateToolStripMenuItem1.Click += new System.EventHandler(this.сalculateToolStripMenuItem1_Click);
            // 
            // generationToolStripMenuItem
            // 
            this.generationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomProjectToolStripMenuItem,
            this.testToolStripMenuItem});
            this.generationToolStripMenuItem.Name = "generationToolStripMenuItem";
            this.generationToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.generationToolStripMenuItem.Text = "Generation";
            // 
            // randomProjectToolStripMenuItem
            // 
            this.randomProjectToolStripMenuItem.Name = "randomProjectToolStripMenuItem";
            this.randomProjectToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.randomProjectToolStripMenuItem.Text = "Random Project";
            this.randomProjectToolStripMenuItem.Click += new System.EventHandler(this.randomProjectToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chartsTabs);
            this.splitContainer1.Size = new System.Drawing.Size(1039, 537);
            this.splitContainer1.SplitterDistance = 346;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tasks);
            this.tabControl1.Controls.Add(this.Links);
            this.tabControl1.Controls.Add(this.tabLog);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(340, 531);
            this.tabControl1.TabIndex = 1;
            // 
            // tasks
            // 
            this.tasks.Controls.Add(this.dataGridViewTasks);
            this.tasks.Location = new System.Drawing.Point(4, 22);
            this.tasks.Name = "tasks";
            this.tasks.Padding = new System.Windows.Forms.Padding(3);
            this.tasks.Size = new System.Drawing.Size(332, 505);
            this.tasks.TabIndex = 1;
            this.tasks.Text = "Tasks";
            this.tasks.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.AllowUserToAddRows = false;
            this.dataGridViewTasks.AllowUserToDeleteRows = false;
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTasks.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.ReadOnly = true;
            this.dataGridViewTasks.Size = new System.Drawing.Size(326, 499);
            this.dataGridViewTasks.TabIndex = 0;
            // 
            // Links
            // 
            this.Links.Controls.Add(this.dataGridViewLinks);
            this.Links.Location = new System.Drawing.Point(4, 22);
            this.Links.Name = "Links";
            this.Links.Size = new System.Drawing.Size(332, 505);
            this.Links.TabIndex = 3;
            this.Links.Text = "Dependencies";
            this.Links.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLinks
            // 
            this.dataGridViewLinks.AllowUserToAddRows = false;
            this.dataGridViewLinks.AllowUserToDeleteRows = false;
            this.dataGridViewLinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLinks.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLinks.Name = "dataGridViewLinks";
            this.dataGridViewLinks.ReadOnly = true;
            this.dataGridViewLinks.Size = new System.Drawing.Size(332, 505);
            this.dataGridViewLinks.TabIndex = 0;
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.console);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(332, 505);
            this.tabLog.TabIndex = 2;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // console
            // 
            this.console.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.console.Location = new System.Drawing.Point(3, 6);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(323, 493);
            this.console.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 531);
            this.dataGridView1.TabIndex = 0;
            // 
            // chartsTabs
            // 
            this.chartsTabs.Controls.Add(this.tabResources);
            this.chartsTabs.Controls.Add(this.tabPage2);
            this.chartsTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartsTabs.Location = new System.Drawing.Point(0, 0);
            this.chartsTabs.Name = "chartsTabs";
            this.chartsTabs.SelectedIndex = 0;
            this.chartsTabs.Size = new System.Drawing.Size(689, 537);
            this.chartsTabs.TabIndex = 0;
            // 
            // tabResources
            // 
            this.tabResources.AutoScroll = true;
            this.tabResources.Controls.Add(this.gantChartContainer);
            this.tabResources.ForeColor = System.Drawing.SystemColors.Window;
            this.tabResources.Location = new System.Drawing.Point(4, 22);
            this.tabResources.Name = "tabResources";
            this.tabResources.Padding = new System.Windows.Forms.Padding(3);
            this.tabResources.Size = new System.Drawing.Size(681, 511);
            this.tabResources.TabIndex = 0;
            this.tabResources.Text = "Resources";
            this.tabResources.UseVisualStyleBackColor = true;
            // 
            // gantChartContainer
            // 
            this.gantChartContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gantChartContainer.IsSplitterFixed = true;
            this.gantChartContainer.Location = new System.Drawing.Point(3, 3);
            this.gantChartContainer.Name = "gantChartContainer";
            this.gantChartContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // gantChartContainer.Panel1
            // 
            this.gantChartContainer.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gantChartContainer.Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.gantChartContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // gantChartContainer.Panel2
            // 
            this.gantChartContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.gantChartContainer.Panel2.Controls.Add(this.pictureBoxPreloader);
            this.gantChartContainer.Size = new System.Drawing.Size(675, 505);
            this.gantChartContainer.SplitterDistance = 33;
            this.gantChartContainer.TabIndex = 0;
            // 
            // pictureBoxPreloader
            // 
            this.pictureBoxPreloader.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPreloader.Image")));
            this.pictureBoxPreloader.Location = new System.Drawing.Point(3, -34);
            this.pictureBoxPreloader.Name = "pictureBoxPreloader";
            this.pictureBoxPreloader.Size = new System.Drawing.Size(667, 497);
            this.pictureBoxPreloader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPreloader.TabIndex = 0;
            this.pictureBoxPreloader.TabStop = false;
            this.pictureBoxPreloader.UseWaitCursor = true;
            this.pictureBoxPreloader.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(681, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Project.json";
            this.openFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "Project.json";
            this.saveFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.";
            // 
            // dataGridViewResources
            // 
            this.dataGridViewResources.AllowUserToAddRows = false;
            this.dataGridViewResources.AllowUserToDeleteRows = false;
            this.dataGridViewResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResources.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewResources.Name = "dataGridViewResources";
            this.dataGridViewResources.ReadOnly = true;
            this.dataGridViewResources.Size = new System.Drawing.Size(326, 499);
            this.dataGridViewResources.TabIndex = 0;
            // 
            // tabPage1
            //
            this.tabPage1.Controls.Add(this.dataGridViewResources);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(332, 505);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Resources";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Progect Sheduler Demo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            this.Links.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinks)).EndInit();
            this.tabLog.ResumeLayout(false);
            this.tabLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.chartsTabs.ResumeLayout(false);
            this.tabResources.ResumeLayout(false);
            this.gantChartContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gantChartContainer)).EndInit();
            this.gantChartContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreloader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResources)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox console;
        private System.Windows.Forms.TabControl chartsTabs;
        internal System.Windows.Forms.TabPage tabResources;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.SplitContainer gantChartContainer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage resources;
        private System.Windows.Forms.TabPage tasks;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сalculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сalculateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxPreloader;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TabPage Links;
        private System.Windows.Forms.DataGridView dataGridViewResources;
        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.DataGridView dataGridViewLinks;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

