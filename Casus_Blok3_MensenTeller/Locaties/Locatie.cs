using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Blok3_MensenTeller.Locaties
{
    public class Locatie
    {
        public int ID { get; set; }
        public string Adres { get; set; }
        public int Nummer { get; set; }
        public string Toevoeging { get; set; }
        public string Plaats { get; set; }
        public string PostCode { get; set; }

        public Locatie()
        {

        }
        public Locatie(int id)
        {
            ID = id;
        }
        public Locatie(int id, string adres)
        {
            ID = id;
            Adres = adres;
        }
        public Locatie(int id, string adres, int nummer)
        {
            ID = id;
            Adres = adres;
            Nummer = nummer;
        }
        public Locatie(int id, string adres, int nummer, string toevoeging)
        {
            ID = id;
            Adres = adres;
            Nummer = nummer;
            Toevoeging = toevoeging;
        }
        public Locatie(int id, string adres, int nummer, string toevoeging, string plaats)
        {
            ID = id;
            Adres = adres;
            Nummer = nummer;
            Toevoeging = toevoeging;
            Plaats = plaats;
        }
        public Locatie(int id, string adres, int nummer, string toevoeging, string plaats, string postcode)
        {
            ID = id;
            Adres = adres;
            Nummer = nummer;
            Toevoeging = toevoeging;
            Plaats = plaats;
            PostCode = postcode;
        }

    }
}
