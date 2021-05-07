using Microsoft.Data.Sqlite;
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
        #region Atribute
        public List<Client> clienti;
        private readonly string connectionString = "Data Source=database.db";
        #endregion

        #region Metode
        public FormClienti(List<Client> clienti)
        {
            InitializeComponent();
            this.clienti = clienti;
            DisplayClienti();
        }

        void DisplayClienti()
        {
            clienti.Sort();
            lvClienti.Items.Clear();
            foreach(Client client in clienti)
            {
                ListViewItem lvItem = new ListViewItem(client.Id.ToString());
                lvItem.SubItems.Add(client.Nume);
                lvItem.SubItems.Add(client.Prenume);
                lvItem.SubItems.Add(client.Telefon);
                lvItem.SubItems.Add(client.DataNasterii.ToString("d"));
                lvItem.SubItems.Add(client.NrRezervari.ToString());

                lvItem.Tag = client;
                lvClienti.Items.Add(lvItem);
            }
        }

        void AddClient(Client client)
        {
            string query = "INSERT INTO Clienti(Nume, Prenume, Telefon, DataNasterii, NrRezervari) VALUES(@nume, @prenume, @telefon, @dataNasterii, @nrRezervari); SELECT last_insert_rowid()";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@nume", client.Nume);
                command.Parameters.AddWithValue("@prenume", client.Prenume);
                command.Parameters.AddWithValue("@telefon", client.Telefon);
                command.Parameters.AddWithValue("@dataNasterii", client.DataNasterii.ToString("d"));
                command.Parameters.AddWithValue("@nrRezervari", client.NrRezervari);

                connection.Open();
                long id = (long)command.ExecuteScalar();
                client.Id = (int)id;

                clienti.Add(client);
            }
        }
        
        void RemoveClient(Client client)
        {
            string query = "DELETE FROM Clienti WHERE Id=@id";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@id", client.Id);

                connection.Open();

                command.ExecuteNonQuery();

                clienti.Remove(client);
            }
        }
        #endregion

        #region Evenimente
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

            AddClient(client);
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
                RemoveClient(client);
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
        #endregion
    }
}
