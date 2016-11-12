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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.console = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chartsTabs = new System.Windows.Forms.TabControl();
            this.tabResources = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gantChartContainer = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.chartsTabs.SuspendLayout();
            this.tabResources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gantChartContainer)).BeginInit();
            this.gantChartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1039, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.console);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chartsTabs);
            this.splitContainer1.Size = new System.Drawing.Size(1039, 537);
            this.splitContainer1.SplitterDistance = 346;
            this.splitContainer1.TabIndex = 1;
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(3, 0);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(340, 534);
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
            this.gantChartContainer.Size = new System.Drawing.Size(675, 505);
            this.gantChartContainer.SplitterDistance = 33;
            this.gantChartContainer.TabIndex = 0;
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
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.chartsTabs.ResumeLayout(false);
            this.tabResources.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gantChartContainer)).EndInit();
            this.gantChartContainer.ResumeLayout(false);
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
    }
}

