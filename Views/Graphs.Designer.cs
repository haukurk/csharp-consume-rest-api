namespace samskip.rating_browser
{
    partial class Graphs
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.chartRatings = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartRatings)).BeginInit();
            this.SuspendLayout();
            // 
            // chartRatings
            // 
            this.chartRatings.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartRatings.Legends.Add(legend1);
            this.chartRatings.Location = new System.Drawing.Point(0, 0);
            this.chartRatings.Name = "chartRatings";
            this.chartRatings.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRatings.Series.Add(series1);
            this.chartRatings.Size = new System.Drawing.Size(696, 440);
            this.chartRatings.TabIndex = 0;
            this.chartRatings.Text = "Ratings Chart";

            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartRatings);
            this.Name = "Graphs";
            this.Size = new System.Drawing.Size(696, 440);
            ((System.ComponentModel.ISupportInitialize)(this.chartRatings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRatings;
    }
}
