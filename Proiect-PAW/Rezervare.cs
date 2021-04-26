using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Rezervare
    {
        #region Atribute
        public DateTime Data { get; set; }
        public int Durata { get; set; }
        public List<Aparat> Aparate { get; set; }

        #endregion

        #region Constructori

        public Rezervare(DateTime data, int durata, List<Aparat> aparate)
        {
            Data = data;
            Durata = durata;
            Aparate = aparate;
        }

        public Rezervare()
        {
        }
        #endregion
    }
}
