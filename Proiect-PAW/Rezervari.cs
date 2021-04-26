using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Rezervari
    {
        #region Atribute
        public DateTime Data { get; set; }
        public int Durata { get; set; }
        public List<Aparate> Aparate { get; set; }

        #endregion

        #region Constructori

        public Rezervari(DateTime data, int durata, List<Aparate> aparate)
        {
            Data = data;
            Durata = durata;
            Aparate = aparate;
        }

        public Rezervari()
        {
        }
        #endregion
    }
}
