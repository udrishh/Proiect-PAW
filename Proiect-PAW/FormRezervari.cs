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
        }
    }
}
