﻿
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAparate = new System.Windows.Forms.Button();
            this.btnRezervari = new System.Windows.Forms.Button();
            this.btnClienti = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelClienti = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelRezervari = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelAparate = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAparate);
            this.groupBox1.Controls.Add(this.btnRezervari);
            this.groupBox1.Controls.Add(this.btnClienti);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}
