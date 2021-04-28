using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class FormClientiEdit : Form
    {
        public Client client = new Client();
        public FormClientiEdit(Client client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void FormClientiEdit_Load(object sender, EventArgs e)
        {
            tbNume.Text = client.Nume;
            tbPrenume.Text = client.Prenume;
            tbTelefon.Text = client.Telefon;
            dtpDataNasterii.Value = client.DataNasterii;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            client.Nume = tbNume.Text.Trim();
            client.Prenume = tbPrenume.Text.Trim();
            client.Telefon = tbTelefon.Text.Trim();
            client.DataNasterii = dtpDataNasterii.Value;
        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            if(tbNume.Text.Trim().Length < 2)
            {
                errorProvider.SetError(tbNume, "Nume invalid!");
                e.Cancel = true;
            }
        }

        private void tbNume_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbNume, null);
        }

        private void tbPrenume_Validating(object sender, CancelEventArgs e)
        {
            if(tbPrenume.Text.Trim().Length < 2)
            {
                errorProvider.SetError(tbPrenume, "Prenume invalid!");
                e.Cancel = true;
            }
        }

        private void tbPrenume_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbPrenume, null);
        }

        private void tbTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (!long.TryParse(tbTelefon.Text, out long result) || tbTelefon.Text.Length != 10)
            {
                errorProvider.SetError(tbTelefon, "Telefon invalid!");
                e.Cancel = true;
            }
        }

        private void tbTelefon_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbTelefon, "Telefon invalid!");
        }

        private void dtpDataNasterii_Validating(object sender, CancelEventArgs e)
        {
            if (dtpDataNasterii.Value >= DateTime.Now)
            {
                errorProvider.SetError(dtpDataNasterii, "Data nasterii este invalida!");
                e.Cancel = true;
            }
        }

        private void dtpDataNasterii_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(dtpDataNasterii, null);
        }
    }
}
