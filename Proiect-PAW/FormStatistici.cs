using CustomChartLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class FormStatistici : Form
    {
        private List<Aparat> aparate = new List<Aparat>();
        private List<Client> clienti = new List<Client>();
        private List<Rezervare> rezervari = new List<Rezervare>();
        public FormStatistici(List<Aparat> aparate, List<Client> clienti, List<Rezervare> rezervari)
        {
            InitializeComponent();
            this.aparate = aparate;
            this.clienti = clienti;
            this.rezervari = rezervari;
        }

        private void inapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnArataStatistici_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now;
            BindingList<Rezervare> copieRezervari = new BindingList<Rezervare>();
            BindingList<Rezervare> rezervariInterval = new BindingList<Rezervare>();

            List<DateTime> zile = new List<DateTime>();
            List<int> nrRezervari = new List<int>();

            foreach (Rezervare rezervare in rezervari)
            {
                copieRezervari.Add(rezervare);
            }

            if(cbInterval.SelectedIndex == 0)
            {
                int totalRezervari = 0;
                startDate = DateTime.Now.AddDays(-6);
                foreach(Rezervare rezervare in copieRezervari)
                {
                    if(rezervare.Data.Date >= startDate.Date && rezervare.Data.Date <= endDate.Date)
                    {
                        rezervariInterval.Add(rezervare);
                    }
                }

                DateTime indexData = startDate.Date;
                for (int i=0;i<7;i++)
                {
                    DateTime aux = indexData;
                    zile.Add(aux.AddDays(i));
                    int nr = 0;
                    foreach (Rezervare rezervare in rezervariInterval)
                    {
                        if (rezervare.Data.Date == aux.AddDays(i).Date)
                        {
                            nr++;
                            totalRezervari++;
                        }
                    }
                    nrRezervari.Add(nr);
                }

                label.Text = "In intervalul " + startDate.Date.ToString("dd.MM.yyyy") + " - " + endDate.Date.ToString("dd.MM.yyyy") + " au fost efectuate " + totalRezervari + " rezervari.";

                ChartValue[] data = new ChartValue[zile.Count];
                for (int i = 0; i < zile.Count; i++)
                {
                    data[i] = new ChartValue(zile[i].ToString("dd.MMM"), nrRezervari[i]);
                }

                chartRezervari.Data = data;
                chartRezervari.Invalidate();
            }
            else if (cbInterval.SelectedIndex == 1)
            {
                int totalRezervari = 0;
                startDate = DateTime.Now.AddDays(-13);
                foreach (Rezervare rezervare in copieRezervari)
                {
                    if (rezervare.Data.Date >= startDate.Date && rezervare.Data.Date <= endDate.Date)
                    {
                        rezervariInterval.Add(rezervare);
                    }
                }

                DateTime indexData = startDate.Date;
                for (int i = 0; i < 14; i++)
                {
                    DateTime aux = indexData;
                    zile.Add(aux.AddDays(i));
                    int nr = 0;
                    foreach (Rezervare rezervare in rezervariInterval)
                    {
                        if (rezervare.Data.Date == aux.AddDays(i).Date)
                        {
                            nr++;
                            totalRezervari++;
                        }
                    }
                    nrRezervari.Add(nr);
                }

                label.Text = "In intervalul " + startDate.Date.ToString("dd.MM.yyyy") + " - " + endDate.Date.ToString("dd.MM.yyyy") + " au fost efectuate " + totalRezervari + " rezervari.";

                ChartValue[] data = new ChartValue[zile.Count];
                for(int i=0; i < zile.Count; i++)
                {
                    data[i] = new ChartValue(zile[i].ToString("dd.MMM"), nrRezervari[i]);
                }

                chartRezervari.Data = data;
                chartRezervari.Invalidate();
            }
            else if (cbInterval.SelectedIndex == 2)
            {
                int totalRezervari = 0;
                endDate = DateTime.Now.Date.AddDays(6);
                foreach (Rezervare rezervare in copieRezervari)
                {
                    if (rezervare.Data.Date >= startDate.Date && rezervare.Data.Date <= endDate.Date)
                    {
                        rezervariInterval.Add(rezervare);
                    }
                }

                DateTime indexData = startDate.Date;
                for (int i = 0; i < 7; i++)
                {
                    DateTime aux = indexData;
                    zile.Add(aux.AddDays(i));
                    int nr = 0;
                    foreach (Rezervare rezervare in rezervariInterval)
                    {
                        if (rezervare.Data.Date == aux.AddDays(i).Date)
                        {
                            nr++;
                            totalRezervari++;
                        }
                    }
                    nrRezervari.Add(nr);
                }

                label.Text = "In intervalul " + startDate.Date.ToString("dd.MM.yyyy") + " - " + endDate.Date.ToString("dd.MM.yyyy") + " au fost efectuate " + totalRezervari + " rezervari.";

                ChartValue[] data = new ChartValue[zile.Count];
                for (int i = 0; i < zile.Count; i++)
                {
                    data[i] = new ChartValue(zile[i].ToString("dd.MMM"), nrRezervari[i]);
                }

                chartRezervari.Data = data;
                chartRezervari.Invalidate();
            }

        }
    }
}
