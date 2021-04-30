
namespace Proiect_PAW
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAparate = new System.Windows.Forms.Button();
            this.btnRezervari = new System.Windows.Forms.Button();
            this.btnClienti = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelClienti = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelRezervari = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelAparate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.exportAs = new System.Windows.Forms.ToolStripLabel();
            this.exportCsv = new System.Windows.Forms.ToolStripDropDownButton();
            this.aparateCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.cleintiCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervariCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.exportBin = new System.Windows.Forms.ToolStripDropDownButton();
            this.aparateBin = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiBin = new System.Windows.Forms.ToolStripMenuItem();
            this.RezervariBin = new System.Windows.Forms.ToolStripMenuItem();
            this.exportXml = new System.Windows.Forms.ToolStripDropDownButton();
            this.aparateXml = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiXml = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervariXml = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAparate);
            this.groupBox1.Controls.Add(this.btnRezervari);
            this.groupBox1.Controls.Add(this.btnClienti);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manager de date";
            // 
            // btnAparate
            // 
            this.btnAparate.Location = new System.Drawing.Point(18, 48);
            this.btnAparate.Name = "btnAparate";
            this.btnAparate.Size = new System.Drawing.Size(157, 23);
            this.btnAparate.TabIndex = 2;
            this.btnAparate.Text = "&Aparate";
            this.btnAparate.UseVisualStyleBackColor = true;
            this.btnAparate.Click += new System.EventHandler(this.btnAparate_Click);
            // 
            // btnRezervari
            // 
            this.btnRezervari.Location = new System.Drawing.Point(18, 77);
            this.btnRezervari.Name = "btnRezervari";
            this.btnRezervari.Size = new System.Drawing.Size(157, 23);
            this.btnRezervari.TabIndex = 1;
            this.btnRezervari.Text = "&Rezervari";
            this.btnRezervari.UseVisualStyleBackColor = true;
            this.btnRezervari.Click += new System.EventHandler(this.btnRezervari_Click);
            // 
            // btnClienti
            // 
            this.btnClienti.Location = new System.Drawing.Point(18, 19);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(157, 23);
            this.btnClienti.TabIndex = 0;
            this.btnClienti.Text = "&Clienti";
            this.btnClienti.UseVisualStyleBackColor = true;
            this.btnClienti.Click += new System.EventHandler(this.btnClienti_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelClienti,
            this.labelRezervari,
            this.labelAparate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelClienti
            // 
            this.labelClienti.Name = "labelClienti";
            this.labelClienti.Size = new System.Drawing.Size(44, 17);
            this.labelClienti.Text = "Clienti:";
            // 
            // labelRezervari
            // 
            this.labelRezervari.Name = "labelRezervari";
            this.labelRezervari.Size = new System.Drawing.Size(57, 17);
            this.labelRezervari.Text = "Rezervari:";
            // 
            // labelAparate
            // 
            this.labelAparate.Name = "labelAparate";
            this.labelAparate.Size = new System.Drawing.Size(51, 17);
            this.labelAparate.Text = "Aparate:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAs,
            this.exportCsv,
            this.exportBin,
            this.exportXml});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // exportAs
            // 
            this.exportAs.Name = "exportAs";
            this.exportAs.Size = new System.Drawing.Size(55, 36);
            this.exportAs.Text = "Export as";
            // 
            // exportCsv
            // 
            this.exportCsv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportCsv.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aparateCsv,
            this.cleintiCSV,
            this.rezervariCsv});
            this.exportCsv.Image = ((System.Drawing.Image)(resources.GetObject("exportCsv.Image")));
            this.exportCsv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportCsv.Name = "exportCsv";
            this.exportCsv.Size = new System.Drawing.Size(45, 36);
            this.exportCsv.Text = "toolStripDropDownButton1";
            this.exportCsv.ToolTipText = "Export data as CSV file";
            // 
            // aparateCsv
            // 
            this.aparateCsv.Name = "aparateCsv";
            this.aparateCsv.Size = new System.Drawing.Size(180, 22);
            this.aparateCsv.Text = "Aparate";
            this.aparateCsv.Click += new System.EventHandler(this.aparateCsv_Click);
            // 
            // cleintiCSV
            // 
            this.cleintiCSV.Name = "cleintiCSV";
            this.cleintiCSV.Size = new System.Drawing.Size(180, 22);
            this.cleintiCSV.Text = "Clienti";
            this.cleintiCSV.Click += new System.EventHandler(this.cleintiCSV_Click);
            // 
            // rezervariCsv
            // 
            this.rezervariCsv.Name = "rezervariCsv";
            this.rezervariCsv.Size = new System.Drawing.Size(180, 22);
            this.rezervariCsv.Text = "Rezervari";
            this.rezervariCsv.Click += new System.EventHandler(this.rezervariCsv_Click);
            // 
            // exportBin
            // 
            this.exportBin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportBin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aparateBin,
            this.clientiBin,
            this.RezervariBin});
            this.exportBin.Image = ((System.Drawing.Image)(resources.GetObject("exportBin.Image")));
            this.exportBin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportBin.Name = "exportBin";
            this.exportBin.Size = new System.Drawing.Size(45, 36);
            this.exportBin.Text = "toolStripButton1";
            this.exportBin.ToolTipText = "Export data as BIN file";
            // 
            // aparateBin
            // 
            this.aparateBin.Name = "aparateBin";
            this.aparateBin.Size = new System.Drawing.Size(180, 22);
            this.aparateBin.Text = "Aparate";
            this.aparateBin.Click += new System.EventHandler(this.aparateBin_Click);
            // 
            // clientiBin
            // 
            this.clientiBin.Name = "clientiBin";
            this.clientiBin.Size = new System.Drawing.Size(180, 22);
            this.clientiBin.Text = "Clienti";
            this.clientiBin.Click += new System.EventHandler(this.clientiBin_Click);
            // 
            // RezervariBin
            // 
            this.RezervariBin.Name = "RezervariBin";
            this.RezervariBin.Size = new System.Drawing.Size(180, 22);
            this.RezervariBin.Text = "Rezervari";
            this.RezervariBin.Click += new System.EventHandler(this.RezervariBin_Click);
            // 
            // exportXml
            // 
            this.exportXml.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportXml.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aparateXml,
            this.clientiXml,
            this.rezervariXml});
            this.exportXml.Image = ((System.Drawing.Image)(resources.GetObject("exportXml.Image")));
            this.exportXml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportXml.Name = "exportXml";
            this.exportXml.Size = new System.Drawing.Size(45, 36);
            this.exportXml.Text = "toolStripDropDownButton2";
            this.exportXml.ToolTipText = "Export data as XML file";
            // 
            // aparateXml
            // 
            this.aparateXml.Name = "aparateXml";
            this.aparateXml.Size = new System.Drawing.Size(180, 22);
            this.aparateXml.Text = "Aparate";
            this.aparateXml.Click += new System.EventHandler(this.aparateXml_Click);
            // 
            // clientiXml
            // 
            this.clientiXml.Name = "clientiXml";
            this.clientiXml.Size = new System.Drawing.Size(180, 22);
            this.clientiXml.Text = "Clienti";
            this.clientiXml.Click += new System.EventHandler(this.clientiXml_Click);
            // 
            // rezervariXml
            // 
            this.rezervariXml.Name = "rezervariXml";
            this.rezervariXml.Size = new System.Drawing.Size(180, 22);
            this.rezervariXml.Text = "Rezervari";
            this.rezervariXml.Click += new System.EventHandler(this.rezervariXml_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Manager Sala de Gimnastica";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAparate;
        private System.Windows.Forms.Button btnRezervari;
        private System.Windows.Forms.Button btnClienti;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelClienti;
        private System.Windows.Forms.ToolStripStatusLabel labelRezervari;
        private System.Windows.Forms.ToolStripStatusLabel labelAparate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton exportCsv;
        private System.Windows.Forms.ToolStripLabel exportAs;
        private System.Windows.Forms.ToolStripMenuItem aparateCsv;
        private System.Windows.Forms.ToolStripMenuItem cleintiCSV;
        private System.Windows.Forms.ToolStripMenuItem rezervariCsv;
        private System.Windows.Forms.ToolStripDropDownButton exportBin;
        private System.Windows.Forms.ToolStripMenuItem aparateBin;
        private System.Windows.Forms.ToolStripMenuItem clientiBin;
        private System.Windows.Forms.ToolStripMenuItem RezervariBin;
        private System.Windows.Forms.ToolStripDropDownButton exportXml;
        private System.Windows.Forms.ToolStripMenuItem aparateXml;
        private System.Windows.Forms.ToolStripMenuItem clientiXml;
        private System.Windows.Forms.ToolStripMenuItem rezervariXml;
    }
}

