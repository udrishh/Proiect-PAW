using System;

namespace Proiect_PAW
{
    [Serializable]
    public class Rezervare : IComparable<Rezervare>
    {
        #region Atribute
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int Durata { get; set; }
        public Client Client { get; set; }
        public Aparat Aparat1 { get; set; }
        public Aparat Aparat2 { get; set; }
        #endregion

        #region Constructori
        public Rezervare(DateTime data, int durata, Aparat aparat1, Aparat aparat2, Client client, int id)
        {
            Data = data;
            Durata = durata;
            Aparat1 = aparat1;
            Aparat2 = aparat2;
            Client = client;
            Id = id;
        }
        public Rezervare()
        {

        }
        #endregion

        #region Metode
        public override string ToString()
        {
            return "#"+Id;
        }
        public int CompareTo(Rezervare other)
        {
            return Id.CompareTo(other.Id);
        }
        #endregion
    }
}
