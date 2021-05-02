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
        private List<Aparat> aparate = new List<Aparat>();
        private List<Client> clienti = new List<Client>();
        private List<Rezervare> rezervari = new List<Rezervare>();

        List<Aparat> aparate1;
        List<Aparat> aparate2;
        public FormRezervari(List<Rezervare> rezervari, List<Aparat> aparate, List<Client> clienti)
        {
            InitializeComponent();
            this.aparate = aparate;
            this.clienti = clienti;
            this.rezervari = rezervari;

            clienti.Sort();
            cbClienti.DataSource = clienti;
            cbClienti.SelectedIndex = -1;
            aparate1 = new List<Aparat>(aparate);
            aparate2 = new List<Aparat>(aparate);
            cbAparat1.DataSource = aparate1;
            cbAparat1.SelectedIndex = -1;
            cbAparat2.DataSource = aparate2;
            cbAparat2.SelectedIndex = -1;
            DisplayRezervari();
        }

        void DisplayRezervari()
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

            //determinare id
            rezervare.Id = 1;
            foreach (Rezervare rezervareExistenta in rezervari)
            {
                if (rezervare.Id == rezervareExistenta.Id)
                {
                    rezervare.Id++;
                }
                else
                {
                    break;
                }
            }

            dtpData.ResetText();
            cbDurata.SelectedIndex = -1;
            cbClienti.SelectedIndex = -1;
            cbAparat1.SelectedIndex = -1;
            cbAparat2.SelectedIndex = -1;

            rezervari.Add(rezervare);
            DisplayRezervari();
            rezervare.Client.NrRezervari++;
        }

        private void btnNou_Click(object sender, EventArgs e)
        {
            FormClienti formClienti = new FormClienti(clienti);
            formClienti.ShowDialog();
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
                rezervari.Remove(rezervare);
                rezervare.Client.NrRezervari--;
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
    }
}
