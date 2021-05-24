using CustomChartLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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

            if (cbInterval.SelectedIndex == 0)
            {
                int totalRezervari = 0;
                startDate = DateTime.Now.AddDays(-6);
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
                btnCopy.Visible = true;
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
                for (int i = 0; i < zile.Count; i++)
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
            btnCopy.Visible = true;
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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

            int totalRezervari = 0;
            startDate = DateTime.Now.AddDays(-6);
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

            var printAreaHight = e.MarginBounds.Height;
            var printAreaWidth = e.MarginBounds.Width;

            var marginLeft = e.MarginBounds.Left;
            var marginTop = e.MarginBounds.Top;

            var maxDotWidth = printAreaWidth / nrRezervari.Count;
            var maxDotHeight = printAreaHight * 0.9;
            int nrRezervariMax = 0;
            for(int i = 0; i < nrRezervari.Count; i++)
            {
                if(nrRezervari[i]> nrRezervariMax)
                {
                    nrRezervariMax = nrRezervari[i];
                }
            }
            var maxValue = nrRezervariMax;
            var scalingFactor = maxDotHeight / maxValue;

            Point lastPoint = new Point(0, 0);

            e.Graphics.FillRectangle(
                    Brushes.LightGray,
                    marginLeft,
                    marginTop,
                    printAreaWidth,
                    printAreaHight
                    );

            for (int i = 0; i < nrRezervari.Count; i++)
            {
                var laneWidth = (float)maxDotWidth;
                e.Graphics.DrawLine(
                    new Pen(Brushes.DarkGray, 2),
                    new Point((int)(marginLeft+25 + i * laneWidth), marginTop+(int)maxDotHeight),
                    new Point((int)(marginLeft + 25 + i * laneWidth), marginTop)
                );
            }

            for (int i = 0; i < nrRezervari.Count; i++)
            {

                var laneHeight = (float)scalingFactor * nrRezervari[i];
                var laneWidth = (float)maxDotWidth;

                if (i > 0)
                {
                    e.Graphics.DrawLine(
                    new Pen(Brushes.LightSeaGreen, 5),
                    new Point((int)(marginLeft + 20 + i * laneWidth), marginTop + (int)(maxDotHeight - laneHeight + 10)),
                    lastPoint
                    );
                }
                lastPoint = new Point((int)(marginLeft + 25 + i * laneWidth), marginTop + (int)(maxDotHeight - laneHeight + 10));

                e.Graphics.DrawString(
                    zile[i].ToString("dd.MMM"),
                    new Font(FontFamily.GenericSerif, 10, FontStyle.Bold),
                    Brushes.Black,
                    new RectangleF(marginLeft + 10 + i * laneWidth, marginTop + printAreaHight - 70, 50, 50)
                    );
            }

            for (int i = 0; i < nrRezervari.Count; i++)
            {
                var laneHeight = (float)scalingFactor * nrRezervari[i];
                var laneWidth = (float)maxDotWidth;

                e.Graphics.FillEllipse(
                    Brushes.SeaGreen,
                    marginLeft + 15 + i * laneWidth,
                    marginTop + (float)maxDotHeight - laneHeight,
                    20,
                    20
                    );
                e.Graphics.DrawString(
                    nrRezervari[i].ToString(),
                    new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold),
                    Brushes.White,
                    new RectangleF(marginLeft + 18 + i * laneWidth, marginTop + (float)maxDotHeight - laneHeight + 2, 50, 50)
                    );
            }

            e.Graphics.DrawString(
                    "Grafic cu numarul de rezervari din fiecare zi pentru saptamana trecuta", 
                    new Font(FontFamily.GenericSerif, 20, FontStyle.Bold),
                    Brushes.Black,
                    new RectangleF(marginLeft + 50, marginTop + printAreaHight - 50, 1000, 1000)
                    );
            

            e.Graphics.DrawString(
                    "Grafic cu numarul de rezervari din fiecare zi pentru saptamana trecuta",
                    new Font(FontFamily.GenericSerif, 20, FontStyle.Bold),
                    Brushes.Black,
                    new RectangleF(marginLeft + 50, marginTop + printAreaHight - 50, 1000, 1000)
                    );
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument.DefaultPageSettings.Landscape = true;
            printPreviewDialog.ShowDialog();
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.DefaultPageSettings.Landscape = true;
                printDocument.Print();
            }
        }

        private void printSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label.Text);
        }
    }
}
