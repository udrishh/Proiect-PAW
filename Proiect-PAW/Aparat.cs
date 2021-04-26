using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Aparat : IComparable<Aparat>
    {
        #region Atribute
        public string Denumire { get; set; }
        public int Id { get; set; }
        #endregion

        #region Constructori

        public Aparat(string denumire, int id)
        {
            Denumire = denumire;
            Id = id;
        }

        public Aparat()
        {
        }

        #endregion

        #region Metode
        public override string ToString()
        {
            return Id + " - " + Denumire;
        }

        public int CompareTo(Aparat other)
        {
            return this.Id.CompareTo(other.Id);
        }

        #endregion
    }
}
