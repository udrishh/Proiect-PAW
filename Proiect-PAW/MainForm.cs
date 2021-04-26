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
    }
}
