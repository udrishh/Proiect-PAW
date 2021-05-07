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
        private Aparat aparat;
        public FormAparateEdit(Aparat aparat)
        {
            InitializeComponent();
            this.aparat = aparat;
        }

        private void FormAparateEdit_Load(object sender, EventArgs e)
        {
            tbDenumire.Text = aparat.Denumire;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            aparat.Denumire = tbDenumire.Text.Trim();
        }

        private void tbDenumire_Validating(object sender, CancelEventArgs e)
        {
            if(tbDenumire.Text.Trim().Length <= 3)
            {
                errorProvider.SetError(tbDenumire, "Denumire invalida!");
                e.Cancel = true;
            }
        }

        private void tbDenumire_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbDenumire, null);
        }
    }
}
