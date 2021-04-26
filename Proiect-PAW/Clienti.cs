﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Clienti
    {
        #region Atribute
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public string DataNasterii { get; set; }
        public List<Rezervari> Rezervari { get; set; }

        #endregion

        #region Constructori

        public Clienti(int id, string nume, string prenume, string telefon, string dataNasterii, List<Rezervari> rezervari)
        {
            this.Id = id;
            Nume = nume;
            Prenume = prenume;
            Telefon = telefon;
            DataNasterii = dataNasterii;
            Rezervari = rezervari;
        }

        public Clienti()
        {
        }
        #endregion
    }
}
