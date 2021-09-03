namespace punchMaster
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.pieChart2 = new LiveCharts.WinForms.PieChart();
            this.SuspendLayout();
            // 
            // pieChart1
            // 
            this.pieChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pieChart1.Location = new System.Drawing.Point(12, 43);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(756, 576);
            this.pieChart1.TabIndex = 7;
            this.pieChart1.Text = "pieChart1";
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Interval = 45000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // pieChart2
            // 
            this.pieChart2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pieChart2.Location = new System.Drawing.Point(722, 375);
            this.pieChart2.Name = "pieChart2";
            this.pieChart2.Size = new System.Drawing.Size(269, 244);
            this.pieChart2.TabIndex = 8;
            this.pieChart2.Text = "pieChart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 631);
            this.Controls.Add(this.pieChart2);
            this.Controls.Add(this.pieChart1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Timer refreshTimer;
        private LiveCharts.WinForms.PieChart pieChart2;
    }
}

