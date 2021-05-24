using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class FormRezervariEdit : Form
    {
        #region Atribute
        Rezervare rezervare = new Rezervare();
        List<Rezervare> rezervari = new List<Rezervare>();
        List<Aparat> aparate1 = new List<Aparat>();
        List<Aparat> aparate2 = new List<Aparat>();
        int index1 = -1;
        int index2 = -1;
        private readonly string connectionString = "Data Source=database.db";
        #endregion

        #region Metode
        public FormRezervariEdit(List<Rezervare> rezervari, Rezervare rezervare, List<Aparat> aparate1, List<Aparat> aparate2, int index1, int index2)
        {
            InitializeComponent();
            this.rezervari = rezervari;
            this.rezervare = rezervare;
            this.aparate1 = aparate1;
            this.aparate2 = aparate2;
            this.index1 = index1;
            this.index2 = index2;
            
        }
        private void UpdateRezervare(Rezervare rezervare)
        {
            string query = "UPDATE Rezervari SET Data=@data, Durata=@durata, Client=@client, Aparat1=@aparat1, Aparat2=@aparat2 WHERE Id=@id";
            using(SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@id", rezervare.Id);
                command.Parameters.AddWithValue("@data", rezervare.Data.ToString("g"));
                command.Parameters.AddWithValue("@durata", rezervare.Durata);
                command.Parameters.AddWithValue("@client", rezervare.Client.Id);
                command.Parameters.AddWithValue("@aparat1", rezervare.Aparat1.Id);
                if (rezervare.Aparat2 != null)
                {
                    command.Parameters.AddWithValue("@aparat2", rezervare.Aparat2.Id);
                }
                else
                {
                    command.Parameters.AddWithValue("@aparat2", 0);
                }

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Evenimente
        private void FormRezervariEdit_Load(object sender, EventArgs e)
        {
            dtpData.Value = rezervare.Data;
            cbDurata.SelectedIndex = rezervare.Durata-1;
            cbAparat1.DataSource = aparate1;
            cbAparat1.SelectedIndex = index1;
            cbAparat2.DataSource = aparate2;
            if(rezervare.Aparat2 != null)
            {
                cbAparat2.SelectedIndex = index2;
            }
            else
            {
                cbAparat2.SelectedIndex = -1;
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            rezervare.Data = dtpData.Value;
            rezervare.Durata = int.Parse(cbDurata.SelectedItem.ToString());
            rezervare.Aparat1 = (Aparat)cbAparat1.SelectedItem;
            if(cbAparat2.SelectedIndex!=-1)
            {
                rezervare.Aparat2 = (Aparat)cbAparat2.SelectedItem;
            }
            UpdateRezervare(rezervare);
        }
        private void dtpData_Validating(object sender, CancelEventArgs e)
        {
            if(dtpData.Value < DateTime.Now)
            {
                errorProvider.SetError(dtpData, "Data este invalida!");
                e.Cancel = true;
            }
        }
        private void dtpData_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(dtpData, null);
        }
        private void cbDurata_Validating(object sender, CancelEventArgs e)
        {
            if(cbDurata.SelectedItem == null)
            {
                errorProvider.SetError(cbDurata, "Selecteaza durata rezervarii");
                e.Cancel = true;
            }
        }
        private void cbDurata_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(cbDurata, null);
        }
        private void cbAparat1_Validating(object sender, CancelEventArgs e)
        {
            if(cbAparat1.SelectedItem == null)
            {
                errorProvider.SetError(cbAparat1, "Cel putin un aparat trebuie selectat");
                e.Cancel = true;
            }
            else
            {
                Aparat aparat = (Aparat)cbAparat1.SelectedItem;
                if(!aparat.IsAvailable(rezervari,dtpData.Value, int.Parse(cbDurata.SelectedItem.ToString())))
                {
                    errorProvider.SetError(cbAparat1, "Aparatul nu este disponibil!");
                    e.Cancel = true;
                }
            }
        }
        private void cbAparat1_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(cbAparat1, null);
        }
        private void cbAparat2_Validating(object sender, CancelEventArgs e)
        {
            if(cbAparat2.SelectedItem.ToString() == cbAparat1.SelectedItem.ToString())
            {
                errorProvider.SetError(cbAparat2, "Alegeti un aparat2 diferit fata de aparat1!");
                e.Cancel = true;
            }
            else
            {
                Aparat aparat = (Aparat)cbAparat2.SelectedItem;
                if (!aparat.IsAvailable(rezervari, dtpData.Value, int.Parse(cbDurata.SelectedItem.ToString())))
                {
                    errorProvider.SetError(cbAparat2, "Aparatul nu este disponibil!");
                    e.Cancel = true;
                }
            }
        }
        private void cbAparat2_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(cbAparat2, null);
        }
        #endregion
    }
}
