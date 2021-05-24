using System;

namespace Proiect_PAW
{
    [Serializable]
    public class Client : IComparable<Client>
    {
        #region Atribute
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public DateTime DataNasterii { get; set; }
        public int NrRezervari { get; set; }

        #endregion

        #region Constructori

        public Client(int id, string nume, string prenume, string telefon, DateTime dataNasterii, int nrRezervari)
        {
            this.Id = id;
            Nume = nume;
            Prenume = prenume;
            Telefon = telefon;
            DataNasterii = dataNasterii;
            NrRezervari = nrRezervari;
        }
        public Client()
        {
        }
        #endregion

        #region Metode
        public override string ToString()
        {
            return Id + " - " + Nume + " " + Prenume;
        }
        public int CompareTo(Client other)
        {
            return Id.CompareTo(other.Id);
        }
        #endregion
    }
}
