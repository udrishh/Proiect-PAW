
namespace Proiect_PAW
{
    partial class FormClientiEdit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataNasterii = new System.Windows.Forms.DateTimePicker();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.tbTelefon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpDataNasterii);
            this.groupBox1.Controls.Add(this.tbPrenume);
            this.groupBox1.Controls.Add(this.tbNume);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 108);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editeaza client";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(348, 80);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(106, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(359, 24);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(188, 20);
            this.tbTelefon.TabIndex = 7;
            this.tbTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.tbTelefon_Validating);
            this.tbTelefon.Validated += new System.EventHandler(this.tbTelefon_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefon";
            // 
            // dtpDataNasterii
            // 
            this.dtpDataNasterii.CustomFormat = "dd MMMM yyyy  -  HH:mm";
            this.dtpDataNasterii.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataNasterii.Location = new System.Drawing.Point(359, 49);
            this.dtpDataNasterii.Name = "dtpDataNasterii";
            this.dtpDataNasterii.Size = new System.Drawing.Size(188, 20);
            this.dtpDataNasterii.TabIndex = 8;
            this.dtpDataNasterii.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDataNasterii_Validating);
            this.dtpDataNasterii.Validated += new System.EventHandler(this.dtpDataNasterii_Validated);
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(85, 49);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(188, 20);
            this.tbPrenume.TabIndex = 6;
            this.tbPrenume.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenume_Validating);
            this.tbPrenume.Validated += new System.EventHandler(this.tbPrenume_Validated);
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(85, 25);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(188, 20);
            this.tbNume.TabIndex = 5;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            this.tbNume.Validated += new System.EventHandler(this.tbNume_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data nasterii";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenume";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(460, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormClientiEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 132);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormClientiEdit";
            this.Text = "Actualizare date client";
            this.Load += new System.EventHandler(this.FormClientiEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataNasterii;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}