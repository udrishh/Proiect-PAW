using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    [Serializable]
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
            if(this.Id == -1)
            {
                return "null";
            }
            else
            {
                return Id + " - " + Denumire;
            }
        }

        public int CompareTo(Aparat other)
        {
            return this.Id.CompareTo(other.Id);
        }

        public bool IsAvailable(List<Rezervare> rezervari, DateTime dataInceput, int durata)
        {
            foreach(Rezervare rezervare in rezervari)
            {
                if(rezervare.Aparat1.ToString() == this.ToString())
                {
                    DateTime DataInceputRezervare = rezervare.Data;
                    DateTime DataSfarsitRezervare = rezervare.Data.AddHours(rezervare.Durata);

                    DateTime dataSfarsit = dataInceput.AddHours(durata);
                    if (((dataInceput <= DataSfarsitRezervare) && (dataInceput >= DataInceputRezervare)) ||
                        ((dataSfarsit <= DataSfarsitRezervare) && (dataSfarsit >= DataInceputRezervare)))
                    {
                        return false;
                    }
                }
                if(rezervare.Aparat2 != null)
                {
                    if(rezervare.Aparat2.ToString() == this.ToString())
                    {
                        DateTime DataInceputRezervare = rezervare.Data;
                        DateTime DataSfarsitRezervare = rezervare.Data.AddHours(rezervare.Durata);

                        DateTime dataSfarsit = dataInceput.AddHours(durata);
                        if (((dataInceput <= DataSfarsitRezervare) && (dataInceput >= DataInceputRezervare)) ||
                            ((dataSfarsit <= DataSfarsitRezervare) && (dataSfarsit >= DataInceputRezervare)))
                        {
                            return false;
                        }
                    }
                }
            }
      
            return true;
        }

        #endregion
    }
}
