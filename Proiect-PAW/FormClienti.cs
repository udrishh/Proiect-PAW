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
    public partial class FormClienti : Form
    {
        public List<Client> clienti;
        public FormClienti(List<Client> clienti)
        {
            InitializeComponent();
            this.clienti = clienti;
            DisplayClienti();
        }

        void DisplayClienti()
        {
            lvClienti.Items.Clear();
            foreach(Client client in clienti)
            {
                ListViewItem lvItem = new ListViewItem(client.Id.ToString());
                lvItem.SubItems.Add(client.Nume);
                lvItem.SubItems.Add(client.Prenume);
                lvItem.SubItems.Add(client.Telefon);
                lvItem.SubItems.Add(client.DataNasterii.ToString("dd.MM.yyyy"));
                lvItem.SubItems.Add(client.NrRezervari.ToString());

                lvItem.Tag = client;
                lvClienti.Items.Add(lvItem);
            }
        }
        private void btnAdaugaClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            if(tbNume.Text.Trim().Length < 2)
            {
                errorProvider.SetError(tbNume, "Nume invalid!");
                return;
            }
            else
            {
                errorProvider.SetError(tbNume, null);
                client.Nume = tbNume.Text.Trim();
            }
            if (tbPrenume.Text.Trim().Length < 2)
            {
                errorProvider.SetError(tbPrenume, "Prenume invalid!");
                return;
            }
            else
            {
                errorProvider.SetError(tbPrenume, null);
                client.Prenume = tbPrenume.Text.Trim();
            }
            if(dtpDataNasterii.Value >= DateTime.Now)
            {
                errorProvider.SetError(dtpDataNasterii, "Data nasterii este invalida!");
                return;
            }
            else
            {
                errorProvider.SetError(dtpDataNasterii, null);
                client.DataNasterii = dtpDataNasterii.Value;
            }
            if(!long.TryParse(tbTelefon.Text,out long result) || tbTelefon.Text.Length!=10)
            {
                errorProvider.SetError(tbTelefon, "Telefon invalid!");
                return;
            }
            else
            {
                errorProvider.SetError(tbTelefon, null);
                client.Telefon = tbTelefon.Text.Trim();
            }
            client.NrRezervari = 0;
            //determinare id
            client.Id = 1;
            foreach (Client clientExistent in clienti)
            {
                if (client.Id == clientExistent.Id)
                {
                    client.Id++;
                }
                else
                {
                    break;
                }
            }
            clienti.Add(client);
            DisplayClienti();
            tbNume.Clear();
            tbPrenume.Clear();
            tbTelefon.Clear();
            dtpDataNasterii.ResetText();
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvClienti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niciun client nu a fost selectat!", "Client invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem lvItem = lvClienti.SelectedItems[0];
            Client client = (Client)lvItem.Tag;

            DialogResult result = MessageBox.Show("Sigur doriti sa stergeti clientul: " +
                client.ToString() + " ?\nAceasta optiune este ireversibila!", "Stergere client",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                clienti.Remove(client);
                DisplayClienti();
            }
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvClienti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niciun client nu a fost selectat!", "client invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem lvItem = lvClienti.SelectedItems[0];
            Client client = (Client)lvItem.Tag;

            FormClientiEdit formClientiEdit = new FormClientiEdit(client);
            if (formClientiEdit.ShowDialog() == DialogResult.OK)
            {
                DisplayClienti();
            }
        }
    }
}
