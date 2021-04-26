using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Aparate
    {
        #region Atribute
        public string Denumire { get; set; }

        #endregion

        #region Constructori

        public Aparate(string denumire)
        {
            Denumire = denumire;
        }

        public Aparate()
        {
        }
        #endregion
    }
}
