
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
            this.gbManagerDate = new System.Windows.Forms.GroupBox();
            this.btnStatistici = new System.Windows.Forms.Button();
            this.btnAparate = new System.Windows.Forms.Button();
            this.btnRezervari = new System.Windows.Forms.Button();
            this.btnClienti = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelClienti = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelRezervari = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelAparate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
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
            this.gbAutentificare = new System.Windows.Forms.GroupBox();
            this.btnAutentificare = new System.Windows.Forms.Button();
            this.tbUtilizator = new System.Windows.Forms.TextBox();
            this.tbParola = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUtilizator = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.gbUtilizator = new System.Windows.Forms.GroupBox();
            this.pictureUtilizator = new System.Windows.Forms.PictureBox();
            this.btn = new System.Windows.Forms.Button();
            this.gbManagerDate.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.gbAutentificare.SuspendLayout();
            this.gbUtilizator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUtilizator)).BeginInit();
            this.SuspendLayout();
            // 
            // gbManagerDate
            // 
            this.gbManagerDate.Controls.Add(this.btnStatistici);
            this.gbManagerDate.Controls.Add(this.btnAparate);
            this.gbManagerDate.Controls.Add(this.btnRezervari);
            this.gbManagerDate.Controls.Add(this.btnClienti);
            this.gbManagerDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbManagerDate.Location = new System.Drawing.Point(12, 56);
            this.gbManagerDate.Name = "gbManagerDate";
            this.gbManagerDate.Size = new System.Drawing.Size(194, 220);
            this.gbManagerDate.TabIndex = 0;
            this.gbManagerDate.TabStop = false;
            this.gbManagerDate.Text = "Manager de date";
            // 
            // btnStatistici
            // 
            this.btnStatistici.Location = new System.Drawing.Point(17, 176);
            this.btnStatistici.Name = "btnStatistici";
            this.btnStatistici.Size = new System.Drawing.Size(157, 23);
            this.btnStatistici.TabIndex = 3;
            this.btnStatistici.Text = "&Statistici";
            this.btnStatistici.UseVisualStyleBackColor = true;
            this.btnStatistici.Click += new System.EventHandler(this.btnStatistici_Click);
            // 
            // btnAparate
            // 
            this.btnAparate.Location = new System.Drawing.Point(17, 59);
            this.btnAparate.Name = "btnAparate";
            this.btnAparate.Size = new System.Drawing.Size(157, 23);
            this.btnAparate.TabIndex = 2;
            this.btnAparate.Text = "&Aparate";
            this.btnAparate.UseVisualStyleBackColor = true;
            this.btnAparate.Click += new System.EventHandler(this.btnAparate_Click);
            // 
            // btnRezervari
            // 
            this.btnRezervari.Location = new System.Drawing.Point(17, 88);
            this.btnRezervari.Name = "btnRezervari";
            this.btnRezervari.Size = new System.Drawing.Size(157, 23);
            this.btnRezervari.TabIndex = 1;
            this.btnRezervari.Text = "&Rezervari";
            this.btnRezervari.UseVisualStyleBackColor = true;
            this.btnRezervari.Click += new System.EventHandler(this.btnRezervari_Click);
            // 
            // btnClienti
            // 
            this.btnClienti.Location = new System.Drawing.Point(17, 30);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(157, 23);
            this.btnClienti.TabIndex = 0;
            this.btnClienti.Text = "&Clienti";
            this.btnClienti.UseVisualStyleBackColor = true;
            this.btnClienti.Click += new System.EventHandler(this.btnClienti_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelClienti,
            this.labelRezervari,
            this.labelAparate});
            this.statusStrip.Location = new System.Drawing.Point(0, 284);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(446, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
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
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAs,
            this.exportCsv,
            this.exportBin,
            this.exportXml});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(446, 39);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
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
            this.aparateCsv.Size = new System.Drawing.Size(121, 22);
            this.aparateCsv.Text = "Aparate";
            this.aparateCsv.Click += new System.EventHandler(this.aparateCsv_Click);
            // 
            // cleintiCSV
            // 
            this.cleintiCSV.Name = "cleintiCSV";
            this.cleintiCSV.Size = new System.Drawing.Size(121, 22);
            this.cleintiCSV.Text = "Clienti";
            this.cleintiCSV.Click += new System.EventHandler(this.cleintiCSV_Click);
            // 
            // rezervariCsv
            // 
            this.rezervariCsv.Name = "rezervariCsv";
            this.rezervariCsv.Size = new System.Drawing.Size(121, 22);
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
            this.aparateBin.Size = new System.Drawing.Size(121, 22);
            this.aparateBin.Text = "Aparate";
            this.aparateBin.Click += new System.EventHandler(this.aparateBin_Click);
            // 
            // clientiBin
            // 
            this.clientiBin.Name = "clientiBin";
            this.clientiBin.Size = new System.Drawing.Size(121, 22);
            this.clientiBin.Text = "Clienti";
            this.clientiBin.Click += new System.EventHandler(this.clientiBin_Click);
            // 
            // RezervariBin
            // 
            this.RezervariBin.Name = "RezervariBin";
            this.RezervariBin.Size = new System.Drawing.Size(121, 22);
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
            this.aparateXml.Size = new System.Drawing.Size(121, 22);
            this.aparateXml.Text = "Aparate";
            this.aparateXml.Click += new System.EventHandler(this.aparateXml_Click);
            // 
            // clientiXml
            // 
            this.clientiXml.Name = "clientiXml";
            this.clientiXml.Size = new System.Drawing.Size(121, 22);
            this.clientiXml.Text = "Clienti";
            this.clientiXml.Click += new System.EventHandler(this.clientiXml_Click);
            // 
            // rezervariXml
            // 
            this.rezervariXml.Name = "rezervariXml";
            this.rezervariXml.Size = new System.Drawing.Size(121, 22);
            this.rezervariXml.Text = "Rezervari";
            this.rezervariXml.Click += new System.EventHandler(this.rezervariXml_Click);
            // 
            // gbAutentificare
            // 
            this.gbAutentificare.Controls.Add(this.btnAutentificare);
            this.gbAutentificare.Controls.Add(this.tbUtilizator);
            this.gbAutentificare.Controls.Add(this.tbParola);
            this.gbAutentificare.Controls.Add(this.labelPassword);
            this.gbAutentificare.Controls.Add(this.labelUtilizator);
            this.gbAutentificare.Controls.Add(this.labelLogin);
            this.gbAutentificare.Location = new System.Drawing.Point(212, 56);
            this.gbAutentificare.Name = "gbAutentificare";
            this.gbAutentificare.Size = new System.Drawing.Size(222, 220);
            this.gbAutentificare.TabIndex = 3;
            this.gbAutentificare.TabStop = false;
            this.gbAutentificare.Text = "Autentificare utilizator";
            // 
            // btnAutentificare
            // 
            this.btnAutentificare.Location = new System.Drawing.Point(73, 176);
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.Size = new System.Drawing.Size(75, 23);
            this.btnAutentificare.TabIndex = 5;
            this.btnAutentificare.Text = "Sign in";
            this.btnAutentificare.UseVisualStyleBackColor = true;
            this.btnAutentificare.Click += new System.EventHandler(this.btnAutentificare_Click);
            // 
            // tbUtilizator
            // 
            this.tbUtilizator.Location = new System.Drawing.Point(32, 104);
            this.tbUtilizator.Name = "tbUtilizator";
            this.tbUtilizator.Size = new System.Drawing.Size(163, 20);
            this.tbUtilizator.TabIndex = 3;
            // 
            // tbParola
            // 
            this.tbParola.Location = new System.Drawing.Point(32, 150);
            this.tbParola.Name = "tbParola";
            this.tbParola.PasswordChar = '*';
            this.tbParola.Size = new System.Drawing.Size(163, 20);
            this.tbParola.TabIndex = 4;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(29, 134);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(40, 13);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Parola:";
            // 
            // labelUtilizator
            // 
            this.labelUtilizator.AutoSize = true;
            this.labelUtilizator.Location = new System.Drawing.Point(29, 88);
            this.labelUtilizator.Name = "labelUtilizator";
            this.labelUtilizator.Size = new System.Drawing.Size(94, 13);
            this.labelUtilizator.TabIndex = 1;
            this.labelUtilizator.Text = "Nume de utilizator:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(29, 30);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(166, 39);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Va rugam sa va autentificati\r\npentru a putea continua!\r\n\r\n";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbUtilizator
            // 
            this.gbUtilizator.Controls.Add(this.pictureUtilizator);
            this.gbUtilizator.Controls.Add(this.btn);
            this.gbUtilizator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbUtilizator.Location = new System.Drawing.Point(212, 56);
            this.gbUtilizator.Name = "gbUtilizator";
            this.gbUtilizator.Size = new System.Drawing.Size(222, 220);
            this.gbUtilizator.TabIndex = 6;
            this.gbUtilizator.TabStop = false;
            this.gbUtilizator.Text = "Utilizator";
            // 
            // pictureUtilizator
            // 
            this.pictureUtilizator.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureUtilizator.ErrorImage")));
            this.pictureUtilizator.Image = ((System.Drawing.Image)(resources.GetObject("pictureUtilizator.Image")));
            this.pictureUtilizator.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureUtilizator.InitialImage")));
            this.pictureUtilizator.Location = new System.Drawing.Point(63, 30);
            this.pictureUtilizator.Name = "pictureUtilizator";
            this.pictureUtilizator.Size = new System.Drawing.Size(100, 100);
            this.pictureUtilizator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUtilizator.TabIndex = 6;
            this.pictureUtilizator.TabStop = false;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(76, 162);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 5;
            this.btn.Text = "Sign out";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(446, 306);
            this.Controls.Add(this.gbUtilizator);
            this.Controls.Add(this.gbAutentificare);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbManagerDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Sala de Gimnastica";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbManagerDate.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.gbAutentificare.ResumeLayout(false);
            this.gbAutentificare.PerformLayout();
            this.gbUtilizator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUtilizator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbManagerDate;
        private System.Windows.Forms.Button btnAparate;
        private System.Windows.Forms.Button btnRezervari;
        private System.Windows.Forms.Button btnClienti;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel labelClienti;
        private System.Windows.Forms.ToolStripStatusLabel labelRezervari;
        private System.Windows.Forms.ToolStripStatusLabel labelAparate;
        private System.Windows.Forms.ToolStrip toolStrip;
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
        private System.Windows.Forms.GroupBox gbAutentificare;
        private System.Windows.Forms.TextBox tbParola;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUtilizator;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button btnAutentificare;
        private System.Windows.Forms.TextBox tbUtilizator;
        private System.Windows.Forms.GroupBox gbUtilizator;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.PictureBox pictureUtilizator;
        private System.Windows.Forms.Button btnStatistici;
    }
}

