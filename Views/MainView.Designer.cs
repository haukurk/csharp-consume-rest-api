namespace samskip.rating_browser
{
    partial class MainView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnExport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLoadWeek = new System.Windows.Forms.Button();
            this.btnLoadYear = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.OnClickQuit);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.splitter1);
            this.panelButtons.Controls.Add(this.btnExport);
            this.panelButtons.Controls.Add(this.button2);
            this.panelButtons.Controls.Add(this.btnLoadWeek);
            this.panelButtons.Controls.Add(this.btnLoadYear);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 394);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(725, 36);
            this.panelButtons.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 36);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(292, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(131, 29);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.OnClickExportExcel);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Last Week";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnClickLoadLastWeek);
            // 
            // btnLoadWeek
            // 
            this.btnLoadWeek.Location = new System.Drawing.Point(92, 4);
            this.btnLoadWeek.Name = "btnLoadWeek";
            this.btnLoadWeek.Size = new System.Drawing.Size(90, 29);
            this.btnLoadWeek.TabIndex = 1;
            this.btnLoadWeek.Text = "Last Month";
            this.btnLoadWeek.UseVisualStyleBackColor = true;
            this.btnLoadWeek.Click += new System.EventHandler(this.OnClickLoadMonth);
            // 
            // btnLoadYear
            // 
            this.btnLoadYear.Location = new System.Drawing.Point(4, 4);
            this.btnLoadYear.Name = "btnLoadYear";
            this.btnLoadYear.Size = new System.Drawing.Size(82, 29);
            this.btnLoadYear.TabIndex = 0;
            this.btnLoadYear.Text = "Last Year";
            this.btnLoadYear.UseVisualStyleBackColor = true;
            this.btnLoadYear.Click += new System.EventHandler(this.OnClickUpdateLastYear);
            // 
            // panelMain
            // 
            this.panelMain.AutoSize = true;
            this.panelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMain.Controls.Add(this.dataGridViewResult);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 28);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(725, 366);
            this.panelMain.TabIndex = 4;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.AllowUserToOrderColumns = true;
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.RowTemplate.Height = 24;
            this.dataGridViewResult.Size = new System.Drawing.Size(725, 366);
            this.dataGridViewResult.TabIndex = 4;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(725, 430);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnLoadYear;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLoadWeek;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dataGridViewResult;

    }
}
