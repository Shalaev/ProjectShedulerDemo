namespace ProjectShedulerDemo.СustomControls.GanttLegend
{
    partial class GanttLegent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.legendColor = new System.Windows.Forms.Label();
            this.legendText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // legendColor
            // 
            this.legendColor.AutoSize = true;
            this.legendColor.BackColor = System.Drawing.Color.Red;
            this.legendColor.ForeColor = System.Drawing.Color.Red;
            this.legendColor.Location = new System.Drawing.Point(3, 0);
            this.legendColor.Name = "legendColor";
            this.legendColor.Size = new System.Drawing.Size(14, 13);
            this.legendColor.TabIndex = 0;
            this.legendColor.Text = "С";
            // 
            // legendText
            // 
            this.legendText.AutoSize = true;
            this.legendText.ForeColor = System.Drawing.Color.Black;
            this.legendText.Location = new System.Drawing.Point(24, 0);
            this.legendText.Name = "legendText";
            this.legendText.Size = new System.Drawing.Size(39, 13);
            this.legendText.TabIndex = 1;
            this.legendText.Text = "legend";
            // 
            // GanttLegent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.legendText);
            this.Controls.Add(this.legendColor);
            this.Name = "GanttLegent";
            this.Size = new System.Drawing.Size(66, 14);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label legendText;
        public System.Windows.Forms.Label legendColor;
    }
}
