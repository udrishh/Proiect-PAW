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

    public partial class FormAparateEdit : Form
    {
        #region Atribute
        private Aparat aparat;
        private readonly string connectionString = "Data Source=database.db";
        #endregion

        #region Metode
        public FormAparateEdit(Aparat aparat)
        {
            InitializeComponent();
            this.aparat = aparat;
        }

        private void UpdateAparat(Aparat aparat)
        {
            string query = "UPDATE Aparate SET Denumire=@denumire WHERE Id=@id";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@denumire", aparat.Denumire);
                command.Parameters.AddWithValue("@id", aparat.Id);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Evenimente
        private void FormAparateEdit_Load(object sender, EventArgs e)
        {
            tbDenumire.Text = aparat.Denumire;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            aparat.Denumire = tbDenumire.Text.Trim();
            UpdateAparat(aparat);
        }

        private void tbDenumire_Validating(object sender, CancelEventArgs e)
        {
            if (tbDenumire.Text.Trim().Length <= 3)
            {
                errorProvider.SetError(tbDenumire, "Denumire invalida!");
                e.Cancel = true;
            }
        }

        private void tbDenumire_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbDenumire, null);
        }
        #endregion
    }
}
