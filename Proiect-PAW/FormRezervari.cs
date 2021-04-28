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
        public FormRezervari(List<Rezervare> rezervari, List<Aparat> aparate, List<Client> clienti)
        {
            InitializeComponent();
            this.aparate = aparate;
            this.clienti = clienti;
            this.rezervari = rezervari;

            cbClienti.DataSource = clienti;
            cbClienti.SelectedIndex = -1;
            List<Aparat> aparate1 = new List<Aparat>(aparate);
            List<Aparat> aparate2 = new List<Aparat>(aparate);
            cbAparat1.DataSource = aparate1;
            cbAparat1.SelectedIndex = -1;
            cbAparat2.DataSource = aparate2;
            cbAparat2.SelectedIndex = -1;
            DisplayRezervari();
        }

        void DisplayRezervari()
        {
            lvRezervari.Items.Clear();
            foreach(Rezervare rezervare in rezervari)
            {
                ListViewItem lvItem = new ListViewItem(rezervare.Id.ToString());
                lvItem.SubItems.Add(rezervare.Data.ToString());
                lvItem.SubItems.Add(rezervare.Durata.ToString());
                lvItem.SubItems.Add(rezervare.Client.ToString());
                lvItem.SubItems.Add(rezervare.Aparat1.ToString());
                if(rezervare.Aparat2 != null)
                {
                    lvItem.SubItems.Add(rezervare.Aparat2.ToString());
                }

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
                rezervare.Client.NrRezervari++;
            }
            if (cbAparat1.SelectedItem == null)
            {
                errorProvider.SetError(cbAparat1, "Cel putin un aparat trebuie selectat!");
                return;
            }
            else
            {
                errorProvider.SetError(cbAparat1, null);
                rezervare.Aparat1 = (Aparat)cbAparat1.SelectedItem;
            }
            if(cbAparat2.SelectedItem == null)
            {
                rezervare.Aparat2 = null;
            }
            else
            if(cbAparat2.SelectedItem.ToString() == cbAparat1.SelectedItem.ToString())
            {
                errorProvider.SetError(cbAparat2, "Alegeti un aparat diferit!");
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
        }
    }
}
