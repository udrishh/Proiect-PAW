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
    public partial class FormAparate : Form
    {
        private List<Aparat> aparate = new List<Aparat>();
        public FormAparate(List<Aparat> aparate)
        {
            InitializeComponent();
            this.aparate = aparate;
            DisplayAparate();
        }

        public void DisplayAparate()
        {
            aparate.Sort();
            lvAparate.Items.Clear();
            foreach(Aparat aparat in aparate)
            {
                ListViewItem lvItem = new ListViewItem(aparat.Id.ToString());
                lvItem.SubItems.Add(aparat.Denumire);

                lvItem.Tag = aparat;

                lvAparate.Items.Add(lvItem);
            }
        }

        private void btnAdaugaAparat_Click(object sender, EventArgs e)
        {
            Aparat aparat = new Aparat();
            aparat.Denumire = tbDenumire.Text.Trim();
            aparat.Id = 1;

            if(aparat.Denumire.Length > 3)
            {
                //determinare id
                foreach (Aparat aparatExistent in aparate)
                {
                    if (aparat.Id == aparatExistent.Id)
                    {
                        aparat.Id++;
                    }
                    else
                    {
                        break;
                    }
                }

                errorProvider.SetError(tbDenumire,null);
                aparate.Add(aparat);
                tbDenumire.ResetText();
                DisplayAparate();
            }
            else
            {
                errorProvider.SetError(tbDenumire, "Denumire invalida!");
            }
            
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvAparate.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niciun aparat nu a fost selectat!","Aparat invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem lvItem = lvAparate.SelectedItems[0];
            Aparat aparat = (Aparat)lvItem.Tag;

            DialogResult result = MessageBox.Show("Sigur doriti sa stergeti aparatul: " +
                aparat.ToString()+ " ?\nAceasta optiune este ireversibila!" , "Stergere aparat",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                aparate.Remove(aparat);
                DisplayAparate();
            }
        }

        private void tbDenumire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAdaugaAparat_Click(sender, null);
            }
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvAparate.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niciun aparat nu a fost selectat!", "Aparat invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem lvItem = lvAparate.SelectedItems[0];
            Aparat aparat = (Aparat)lvItem.Tag;

            FormAparateEdit formAparateEdit = new FormAparateEdit(aparat);
            if(formAparateEdit.ShowDialog() == DialogResult.OK)
            {
                DisplayAparate();
            }
        }
    }
}
