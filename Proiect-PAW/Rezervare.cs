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
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int Durata { get; set; }
        public Client Client { get; set; }
        public List<Aparat> Aparate { get; set; }

        #endregion

        #region Constructori

        public Rezervare(DateTime data, int durata, List<Aparat> aparate,Client client, int id)
        {
            Data = data;
            Durata = durata;
            Aparate = aparate;
            Client = client;
            Id = id;
        }

        public Rezervare()
        {
        }
        #endregion
    }
}
