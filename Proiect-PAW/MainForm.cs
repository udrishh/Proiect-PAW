using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
    }
}
