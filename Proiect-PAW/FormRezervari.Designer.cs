
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
            this.lvRezervari = new System.Windows.Forms.ListView();
            this.btnAdaugaRezervare = new System.Windows.Forms.Button();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.durata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aparat1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aparat2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.lvRezervari.FullRowSelect = true;
            this.lvRezervari.GridLines = true;
            this.lvRezervari.HideSelection = false;
            this.lvRezervari.Location = new System.Drawing.Point(12, 12);
            this.lvRezervari.Name = "lvRezervari";
            this.lvRezervari.Size = new System.Drawing.Size(486, 399);
            this.lvRezervari.TabIndex = 0;
            this.lvRezervari.UseCompatibleStateImageBehavior = false;
            this.lvRezervari.View = System.Windows.Forms.View.Details;
            // 
            // btnAdaugaRezervare
            // 
            this.btnAdaugaRezervare.Location = new System.Drawing.Point(282, 417);
            this.btnAdaugaRezervare.Name = "btnAdaugaRezervare";
            this.btnAdaugaRezervare.Size = new System.Drawing.Size(216, 23);
            this.btnAdaugaRezervare.TabIndex = 1;
            this.btnAdaugaRezervare.Text = "Adauga Rezervare";
            this.btnAdaugaRezervare.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.Text = "Id";
            // 
            // data
            // 
            this.data.Text = "Data";
            this.data.Width = 180;
            // 
            // durata
            // 
            this.durata.Text = "Durata";
            // 
            // client
            // 
            this.client.Text = "Client";
            // 
            // aparat1
            // 
            this.aparat1.Text = "Aparat 1";
            // 
            // aparat2
            // 
            this.aparat2.Text = "Aparat 2";
            // 
            // FormRezervari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.btnAdaugaRezervare);
            this.Controls.Add(this.lvRezervari);
            this.Name = "FormRezervari";
            this.Text = "FormRezervari";
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
    }
}