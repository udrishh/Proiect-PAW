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
            XmlSerializer serializer = new XmlSerializer(typeof(List<Aparat>));
            using(FileStream stream = File.OpenRead("aparate.xml"))
            {
                aparate = (List<Aparat>)serializer.Deserialize(stream);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //serializare aparate
            XmlSerializer serializer = new XmlSerializer(typeof(List<Aparat>));
            using (FileStream stream = File.Create("aparate.xml"))
            {
                serializer.Serialize(stream, aparate);
            }
        }
    }
}
