﻿using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Proiect_PAW
{
    public partial class MainForm : Form
    {
        #region Atribute
        private List<Aparat> aparate = new List<Aparat>();
        private List<Client> clienti = new List<Client>();
        private List<Rezervare> rezervari = new List<Rezervare>();
        private readonly string connectionString = "Data Source=database.db";
        #endregion

        #region Metode
        public MainForm()
        {
            InitializeComponent();
            gbManagerDate.Enabled = false;
            toolStrip.Enabled = false;
            gbUtilizator.Visible = false;
        }

        private void LoadAparate()
        {
            string query = "SELECT * FROM Aparate";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);

                connection.Open();
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["Id"];
                        string denumire = (string)reader["Denumire"];

                        Aparat aparat = new Aparat(denumire, (int)id);
                        aparate.Add(aparat);
                    }
                }
            }
        }
        private void LoadClienti()
        {
            string query = "SELECT * FROM Clienti";

            using(SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);

                connection.Open();
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        long id = (long)reader["Id"];
                        string nume = (string)reader["Nume"];
                        string prenume = (string)reader["Prenume"];
                        string telefon = (string)reader["Telefon"];
                        DateTime dataNasterii = DateTime.Parse((string)reader["DataNasterii"]);
                        long nrRezervari = (long)reader["NrRezervari"];

                        Client client = new Client((int)id, nume, prenume, telefon, dataNasterii, (int)nrRezervari);
                        clienti.Add(client);
                    }
                }
            }
        }
        #endregion

        #region Evenimente
        private void btnAparate_Click(object sender, EventArgs e)
        {
            FormAparate formAparate = new FormAparate(aparate);
            formAparate.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadAparate();
            LoadClienti();
        }

        private void btnClienti_Click(object sender, EventArgs e)
        {
            FormClienti formClienti = new FormClienti(clienti);
            formClienti.ShowDialog();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            labelClienti.Text = "Clienti: " + clienti.Count;
            labelAparate.Text = "Aparate: " + aparate.Count;
            labelRezervari.Text = "Rezervari: " + rezervari.Count;
        }

        private void btnRezervari_Click(object sender, EventArgs e)
        {
            FormRezervari formRezervari = new FormRezervari(rezervari, aparate, clienti);
            formRezervari.ShowDialog();
        }

        private void aparateBin_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary file|*.bin";
            saveFileDialog.Title = "Salvare date aparate in format binar";
            if( saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName!= "")
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = File.Create(saveFileDialog.FileName))
                {
                    formatter.Serialize(stream, aparate);
                }
            }
        }

        private void clientiBin_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary file|*.bin";
            saveFileDialog.Title = "Salvare date clienti in format binar";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = File.Create(saveFileDialog.FileName))
                {
                    formatter.Serialize(stream, clienti);
                }
            }
        }

        private void RezervariBin_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary file|*.bin";
            saveFileDialog.Title = "Salvare date rezervari in format binar";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = File.Create(saveFileDialog.FileName))
                {
                    formatter.Serialize(stream, rezervari);
                }
            }
        }

        private void aparateXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML file|*.xml";
            saveFileDialog.Title = "Salvare date aparate in format XML";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Aparat>));
                using (FileStream stream = File.Create(saveFileDialog.FileName))
                {
                    serializer.Serialize(stream, aparate);
                }
            }
        }

        private void clientiXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML file|*.xml";
            saveFileDialog.Title = "Salvare date clienti in format XML";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
                using (FileStream stream = File.Create(saveFileDialog.FileName))
                {
                    serializer.Serialize(stream, clienti);
                }
            }
        }

        private void rezervariXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML file|*.xml";
            saveFileDialog.Title = "Salvare date rezervari in format XML";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Rezervare>));
                using (FileStream stream = File.Create(saveFileDialog.FileName))
                {
                    serializer.Serialize(stream, rezervari);
                }
            }
        }

        private void aparateCsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV file|*.csv";
            saveFileDialog.Title = "Salvare date aparate in format CSV";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
            {
                using (StreamWriter writer = File.CreateText(saveFileDialog.FileName))
                {
                    writer.WriteLine("Id, Denumire");
                    foreach (Aparat aparat in aparate)
                    {
                        writer.WriteLine($"{aparat.Id}, {aparat.Denumire}");
                    }
                }
            }
        }

        private void cleintiCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV file|*.csv";
            saveFileDialog.Title = "Salvare date clienti in format CSV";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
            {
                using (StreamWriter writer = File.CreateText(saveFileDialog.FileName))
                {
                    writer.WriteLine("Id, Nume, Prenume, Telefon, Data Nasterii, Nr. rezervari");
                    foreach (Client client in clienti)
                    {
                        writer.WriteLine($"{client.Id}, {client.Nume}, {client.Prenume}, {client.Telefon}, {client.DataNasterii}, {client.NrRezervari}");
                    }
                }
            }
        }

        private void rezervariCsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV file|*.csv";
            saveFileDialog.Title = "Salvare date rezervari in format CSV";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
            {
                using (StreamWriter writer = File.CreateText(saveFileDialog.FileName))
                {
                    writer.WriteLine("Id, Data, Durata, Client, Aparat 1, Aparat 2");
                    foreach (Rezervare rezervare in rezervari)
                    {
                        writer.WriteLine($"{rezervare.Id}, {rezervare.Data}, {rezervare.Durata}, {rezervare.Client}, {rezervare.Aparat1}, {rezervare.Aparat2}");
                    }
                }
            }
        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {
            if((tbUtilizator.Text == "admin" && tbParola.Text == "admin") || (tbUtilizator.Text == "Bogdan" && tbParola.Text == "pass"))
            {
                gbManagerDate.Enabled = true;
                toolStrip.Enabled = true;
                gbUtilizator.Visible = true;
                gbAutentificare.Visible = false;
                gbUtilizator.Text = "Salut, " + tbUtilizator.Text + "!";
                tbUtilizator.Clear();
                tbParola.Clear();
            }
            else
            {
                MessageBox.Show("Nume de utilizator si/sau parola incorecta!", "Eroare autentificare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbParola.Clear();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            gbAutentificare.Visible = true;
            gbManagerDate.Enabled = false;
            toolStrip.Enabled = false;
            gbUtilizator.Visible = false;
        }
        #endregion
    }
}
