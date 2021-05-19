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
    public partial class FormRezervari : Form
    {
        #region Atribute
        private List<Aparat> aparate = new List<Aparat>();
        private List<Client> clienti = new List<Client>();
        private List<Rezervare> rezervari = new List<Rezervare>();
        private List<Aparat> aparate1;
        private List<Aparat> aparate2;
        private readonly string connectionString = "Data Source=database.db";
        #endregion

        #region Metode
        public FormRezervari(List<Rezervare> rezervari, List<Aparat> aparate, List<Client> clienti)
        {
            InitializeComponent();
            this.aparate = aparate;
            this.clienti = clienti;
            this.rezervari = rezervari;

            BindingList<Client> clientiComboBox = new BindingList<Client>(clienti);

            clienti.Sort();
            cbClienti.DataSource = clientiComboBox;
            cbClienti.SelectedIndex = -1;
            aparate1 = new List<Aparat>(aparate);
            aparate2 = new List<Aparat>(aparate);
            cbAparat1.DataSource = aparate1;
            cbAparat1.SelectedIndex = -1;
            cbAparat2.DataSource = aparate2;
            cbAparat2.SelectedIndex = -1;

            DisplayRezervari();
        }

        private void DisplayRezervari()
        {
            rezervari.Sort();
            lvRezervari.Items.Clear();
            foreach(Rezervare rezervare in rezervari)
            {
                ListViewItem lvItem = new ListViewItem(rezervare.Id.ToString());
                lvItem.SubItems.Add(rezervare.Data.ToString("dd.MMMM.yyyy - HH:mm"));
                lvItem.SubItems.Add(rezervare.Durata.ToString());
                lvItem.SubItems.Add(rezervare.Client.ToString());
                lvItem.SubItems.Add(rezervare.Aparat1.ToString());
                if(rezervare.Aparat2 !=null)
                    lvItem.SubItems.Add(rezervare.Aparat2.ToString());

                lvItem.Tag = rezervare;

                lvRezervari.Items.Add(lvItem);
            }
        }
        
        private void AddRezervare(Rezervare rezervare)
        {
            string query = "INSERT INTO Rezervari(Data, Durata, Client, Aparat1, Aparat2) VALUES(@data, @durata, @client, @aparat1, @aparat2); SELECT last_insert_rowid()";

            using(SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@data", rezervare.Data.ToString("g"));
                command.Parameters.AddWithValue("@durata", rezervare.Durata);
                command.Parameters.AddWithValue("@client", rezervare.Client.Id);
                command.Parameters.AddWithValue("@aparat1", rezervare.Aparat1.Id);
                if(rezervare.Aparat2 != null)
                {
                    command.Parameters.AddWithValue("@aparat2", rezervare.Aparat2.Id);
                }
                else
                {
                    command.Parameters.AddWithValue("@aparat2", 0);
                }

                connection.Open();
                long id = (long)command.ExecuteScalar();
                rezervare.Id = (int)id;


                rezervari.Add(rezervare);
            }

            //rezervare.Client.NrRezervari++;
            string query2 = "UPDATE Clienti SET NrRezervari=NrRezervari+1 WHERE Id=@id";

            using(SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query2, connection);
                command.Parameters.AddWithValue("@id", rezervare.Client.Id);

                connection.Open();

                command.ExecuteNonQuery();
            }

        }

        private void RemoveRezervare(Rezervare rezervare)
        {
            string query = "DELETE FROM Rezervari WHERE Id=@id";

            using(SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@id", rezervare.Id);

                connection.Open();

                command.ExecuteNonQuery();

                rezervari.Remove(rezervare);
            }

            rezervare.Client.NrRezervari--;
            string query2 = "UPDATE Clienti SET NrRezervari=NrRezervari-1 WHERE Id=@id";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query2, connection);
                command.Parameters.AddWithValue("@id", rezervare.Client.Id);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Evenimente
        private void btnAdaugaRezervare_Click(object sender, EventArgs e)
        {
            Rezervare rezervare = new Rezervare();
            if (dtpData.Value < DateTime.Now)
            {
                errorProvider.SetError(dtpData, "Data este invalida!");
                return;
            }
            else
            {
                errorProvider.SetError(dtpData, null);
                rezervare.Data = dtpData.Value;
            }
            if(cbDurata.SelectedItem == null)
            {
                errorProvider.SetError(cbDurata, "Selecteaza durata rezervarii!");
                return;
            }
            else
            {
                errorProvider.SetError(cbDurata, null);
                rezervare.Durata = int.Parse(cbDurata.SelectedItem.ToString());
            }
            if(cbClienti.SelectedItem == null)
            {
                errorProvider.SetError(cbClienti, "Selecteaza clientul!");
                return;
            }
            else
            {
                errorProvider.SetError(cbClienti, null);
                rezervare.Client = (Client)cbClienti.SelectedItem;
            }
            Aparat aparat1 = (Aparat)cbAparat1.SelectedItem;
            if (cbAparat1.SelectedItem == null)
            {
                errorProvider.SetError(cbAparat1, "Cel putin un aparat trebuie selectat");
                return;
            }
            else
            if (!aparat1.IsAvailable(rezervari, dtpData.Value, int.Parse(cbDurata.SelectedItem.ToString())))
            {
                errorProvider.SetError(cbAparat1, "Aparatul nu este disponibil!");
                return;
            }
            else
            {
                errorProvider.SetError(cbAparat1, null);
                rezervare.Aparat1 = (Aparat)cbAparat1.SelectedItem;
            }
            Aparat aparat2 = (Aparat)cbAparat2.SelectedItem;
            if(cbAparat2.SelectedItem == null)
            {
                rezervare.Aparat2 = null;
            }
            else
            if (!aparat2.IsAvailable(rezervari, dtpData.Value, int.Parse(cbDurata.SelectedItem.ToString())))
            {
                errorProvider.SetError(cbAparat2, "Aparatul nu este disponibil!");
                return;
            }
            else
            if (cbAparat2.SelectedItem.ToString() == cbAparat1.SelectedItem.ToString())
            {
                errorProvider.SetError(cbAparat2, "Alegeti un aparat2 diferit fata de aparat1!");
                return;
            }
            else
            {
                errorProvider.SetError(cbAparat2, null);
                rezervare.Aparat2 = (Aparat)cbAparat2.SelectedItem;
            }

            dtpData.ResetText();
            cbDurata.SelectedIndex = -1;
            cbClienti.SelectedIndex = -1;
            cbAparat1.SelectedIndex = -1;
            cbAparat2.SelectedIndex = -1;

            AddRezervare(rezervare);
            DisplayRezervari();
            rezervare.Client.NrRezervari++;
        }

        private void btnNou_Click(object sender, EventArgs e)
        {
            FormClienti formClienti = new FormClienti(clienti);
            formClienti.ShowDialog();

            BindingList<Client> clientiComboBox = new BindingList<Client>(clienti);
            cbClienti.DataSource = clientiComboBox;
            cbClienti.SelectedIndex = -1;
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvRezervari.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nicio rezervare nu a fost selectata!", "Rezervare invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem lvItem = lvRezervari.SelectedItems[0];
            Rezervare rezervare = (Rezervare)lvItem.Tag;

            DialogResult result = MessageBox.Show("Sigur doriti sa stergeti Rezervarea: " +
                rezervare.ToString() + " ?\nAceasta optiune este ireversibila!", "Stergere rezervare",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                RemoveRezervare(rezervare);
                DisplayRezervari();
            }
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvRezervari.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nicio rezervare nu a fost selectata!", "Rezervare invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem lvItem = lvRezervari.SelectedItems[0];
            Rezervare rezervare = (Rezervare)lvItem.Tag;
            int index1=-1;
            int index2=-1;
            int i = 0;
            foreach(Aparat aparat in aparate)
            {
                if(aparat.ToString() == rezervare.Aparat1.ToString())
                {
                    index1 = i;
                }
                if(rezervare.Aparat2 == null)
                {
                    index2 = -1;
                }
                else
                if (aparat.ToString() == rezervare.Aparat2.ToString())
                {
                    index2 = i;
                }
                i++;
            }

            FormRezervariEdit formRezervariEdit = new FormRezervariEdit(rezervari,rezervare, aparate1, aparate2, index1, index2);
            if(formRezervariEdit.ShowDialog() == DialogResult.OK)
            {
                DisplayRezervari();
            }
        }
        #endregion

        private void inapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
