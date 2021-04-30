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
        private List<Aparat> aparate = new List<Aparat>();
        private List<Client> clienti = new List<Client>();
        private List<Rezervare> rezervari = new List<Rezervare>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAparate_Click(object sender, EventArgs e)
        {
            FormAparate formAparate = new FormAparate(aparate);
            formAparate.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //deserializare aparate
            XmlSerializer serializerAparate = new XmlSerializer(typeof(List<Aparat>));
            using(FileStream streamAparate = File.OpenRead("aparate.xml"))
            {
                aparate = (List<Aparat>)serializerAparate.Deserialize(streamAparate);
            }
            //deserializare clienti
            XmlSerializer serializerClienti = new XmlSerializer(typeof(List<Client>));
            using (FileStream streamClienti = File.OpenRead("clienti.xml"))
            {
                clienti = (List<Client>)serializerClienti.Deserialize(streamClienti);
            }
            //deserializare rezervari
            XmlSerializer serializerRezervari = new XmlSerializer(typeof(List<Rezervare>));
            using (FileStream streamRezervari = File.OpenRead("rezervari.xml"))
            {
                rezervari = (List<Rezervare>)serializerRezervari.Deserialize(streamRezervari);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //serializare aparate
            XmlSerializer serializerAparate = new XmlSerializer(typeof(List<Aparat>));
            using (FileStream streamAparate = File.Create("aparate.xml"))
            {
                serializerAparate.Serialize(streamAparate, aparate);
            }
            //serializare clienti
            XmlSerializer serializerClienti = new XmlSerializer(typeof(List<Client>));
            using (FileStream streamClienti = File.Create("clienti.xml"))
            {
                serializerClienti.Serialize(streamClienti, clienti);
            }
            //serializare rezervari
            XmlSerializer serializerRezervari = new XmlSerializer(typeof(List<Rezervare>));
            using (FileStream streamRezervari = File.Create("rezervari.xml"))
            {
                serializerRezervari.Serialize(streamRezervari, rezervari);
            }
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
                //binary aparate
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
                //binary clienti
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
                //binary rezervari
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = File.Create(saveFileDialog.FileName))
                {
                    formatter.Serialize(stream, rezervari);
                }
            }
        }
    }
}
