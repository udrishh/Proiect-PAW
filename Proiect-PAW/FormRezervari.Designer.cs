
using System.Windows.Forms;

namespace Proiect_PAW
{
    partial class FormRezervari
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
            this.lvRezervari = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.durata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aparat1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aparat2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdaugaRezervare = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAparat2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAparat1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNou = new System.Windows.Forms.Button();
            this.cbDurata = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbClienti = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvRezervari
            // 
            this.lvRezervari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.data,
            this.durata,
            this.client,
            this.aparat1,
            this.aparat2});
            this.lvRezervari.ContextMenuStrip = this.contextMenuStrip;
            this.lvRezervari.FullRowSelect = true;
            this.lvRezervari.GridLines = true;
            this.lvRezervari.HideSelection = false;
            this.lvRezervari.Location = new System.Drawing.Point(12, 12);
            this.lvRezervari.Name = "lvRezervari";
            this.lvRezervari.Size = new System.Drawing.Size(780, 399);
            this.lvRezervari.TabIndex = 0;
            this.lvRezervari.UseCompatibleStateImageBehavior = false;
            this.lvRezervari.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Id";
            this.id.Width = 30;
            // 
            // data
            // 
            this.data.Text = "Data";
            this.data.Width = 120;
            // 
            // durata
            // 
            this.durata.Text = "Durata";
            this.durata.Width = 45;
            // 
            // client
            // 
            this.client.Text = "Client";
            this.client.Width = 180;
            // 
            // aparat1
            // 
            this.aparat1.Text = "Aparat 1";
            this.aparat1.Width = 200;
            // 
            // aparat2
            // 
            this.aparat2.Text = "Aparat 2";
            this.aparat2.Width = 200;
            // 
            // btnAdaugaRezervare
            // 
            this.btnAdaugaRezervare.Location = new System.Drawing.Point(431, 74);
            this.btnAdaugaRezervare.Name = "btnAdaugaRezervare";
            this.btnAdaugaRezervare.Size = new System.Drawing.Size(110, 23);
            this.btnAdaugaRezervare.TabIndex = 1;
            this.btnAdaugaRezervare.Text = "Adauga Rezervare";
            this.btnAdaugaRezervare.UseVisualStyleBackColor = true;
            this.btnAdaugaRezervare.Click += new System.EventHandler(this.btnAdaugaRezervare_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbClienti);
            this.groupBox1.Controls.Add(this.cbAparat2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbAparat1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnNou);
            this.groupBox1.Controls.Add(this.cbDurata);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdaugaRezervare);
            this.groupBox1.Location = new System.Drawing.Point(112, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adauga rezervare noua";
            // 
            // cbAparat2
            // 
            this.cbAparat2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAparat2.FormattingEnabled = true;
            this.cbAparat2.Location = new System.Drawing.Point(355, 48);
            this.cbAparat2.Name = "cbAparat2";
            this.cbAparat2.Size = new System.Drawing.Size(186, 21);
            this.cbAparat2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Aparat 2";
            // 
            // cbAparat1
            // 
            this.cbAparat1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAparat1.FormattingEnabled = true;
            this.cbAparat1.Location = new System.Drawing.Point(355, 21);
            this.cbAparat1.Name = "cbAparat1";
            this.cbAparat1.Size = new System.Drawing.Size(186, 21);
            this.cbAparat1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Aparat 1";
            // 
            // btnNou
            // 
            this.btnNou.Location = new System.Drawing.Point(252, 71);
            this.btnNou.Name = "btnNou";
            this.btnNou.Size = new System.Drawing.Size(35, 21);
            this.btnNou.TabIndex = 8;
            this.btnNou.Text = "Nou";
            this.btnNou.UseVisualStyleBackColor = true;
            this.btnNou.Click += new System.EventHandler(this.btnNou_Click);
            // 
            // cbDurata
            // 
            this.cbDurata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDurata.FormattingEnabled = true;
            this.cbDurata.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbDurata.Location = new System.Drawing.Point(75, 45);
            this.cbDurata.Name = "cbDurata";
            this.cbDurata.Size = new System.Drawing.Size(170, 21);
            this.cbDurata.TabIndex = 7;
            // 
            // dtpData
            // 

            this.dtpData.CustomFormat = "dd MMMM yyyy  -  HH:mm";
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(45, 20);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Durata (ore)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cbClienti
            // 
            this.cbClienti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClienti.FormattingEnabled = true;
            this.cbClienti.Location = new System.Drawing.Point(75, 71);
            this.cbClienti.Name = "cbClienti";
            this.cbClienti.Size = new System.Drawing.Size(171, 21);
            this.cbClienti.TabIndex = 13;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeazaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(118, 48);
            // 
            // editeazaToolStripMenuItem
            // 
            this.editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            this.editeazaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editeazaToolStripMenuItem.Text = "Editeaza";
            this.editeazaToolStripMenuItem.Click += new System.EventHandler(this.editeazaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // FormRezervari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvRezervari);
            this.Name = "FormRezervari";
            this.Text = "Manager rezervari";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvRezervari;
        private System.Windows.Forms.Button btnAdaugaRezervare;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.ColumnHeader durata;
        private System.Windows.Forms.ColumnHeader client;
        private System.Windows.Forms.ColumnHeader aparat1;
        private System.Windows.Forms.ColumnHeader aparat2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAparat2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAparat1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNou;
        private System.Windows.Forms.ComboBox cbDurata;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private ComboBox cbClienti;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem editeazaToolStripMenuItem;
        private ToolStripMenuItem stergeToolStripMenuItem;
    }
}