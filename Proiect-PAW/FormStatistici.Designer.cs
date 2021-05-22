
namespace Proiect_PAW
{
    partial class FormStatistici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistici));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbInterval = new System.Windows.Forms.ComboBox();
            this.btnArataStatistici = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.chartRezervari = new CustomChartLibrary.ChartControl();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inapoiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inapoiToolStripMenuItem
            // 
            this.inapoiToolStripMenuItem.Name = "inapoiToolStripMenuItem";
            this.inapoiToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.inapoiToolStripMenuItem.Text = "Inapoi";
            this.inapoiToolStripMenuItem.Click += new System.EventHandler(this.inapoiToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartRezervari);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 524);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numar de rezervari efectuate zilnic pentru intervalul ales: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alege intervalul pentru vizualizarea datelor:\r\n";
            // 
            // cbInterval
            // 
            this.cbInterval.FormattingEnabled = true;
            this.cbInterval.Items.AddRange(new object[] {
            "Ultima saptamana",
            "Ultimele doua saptamani",
            "Saptamana viitoare"});
            this.cbInterval.Location = new System.Drawing.Point(231, 34);
            this.cbInterval.Name = "cbInterval";
            this.cbInterval.Size = new System.Drawing.Size(150, 21);
            this.cbInterval.TabIndex = 3;
            // 
            // btnArataStatistici
            // 
            this.btnArataStatistici.Location = new System.Drawing.Point(406, 34);
            this.btnArataStatistici.Name = "btnArataStatistici";
            this.btnArataStatistici.Size = new System.Drawing.Size(138, 21);
            this.btnArataStatistici.TabIndex = 4;
            this.btnArataStatistici.Text = "Arata statistici";
            this.btnArataStatistici.UseVisualStyleBackColor = true;
            this.btnArataStatistici.Click += new System.EventHandler(this.btnArataStatistici_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(9, 603);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(161, 13);
            this.label.TabIndex = 5;
            this.label.Text = "Niciun interval nu a fost selectat!";
            // 
            // chartRezervari
            // 
            this.chartRezervari.Data = null;
            this.chartRezervari.Location = new System.Drawing.Point(6, 19);
            this.chartRezervari.Name = "chartRezervari";
            this.chartRezervari.Size = new System.Drawing.Size(876, 499);
            this.chartRezervari.TabIndex = 1;
            this.chartRezervari.Text = "chartControl1";
            // 
            // FormStatistici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 625);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnArataStatistici);
            this.Controls.Add(this.cbInterval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormStatistici";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statistici rezervari";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inapoiToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbInterval;
        private System.Windows.Forms.Button btnArataStatistici;
        private System.Windows.Forms.Label label;
        private CustomChartLibrary.ChartControl chartRezervari;
    }
}