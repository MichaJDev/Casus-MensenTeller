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
        public string Name { get; set; }
        public string Description { get; set; }
        public string Xco { get; set; }
        public string Yco { get; set; }

        public Locatie()
        {

        }
        public Locatie(int id)
        {
            ID = id;
        }
        public Locatie(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public Locatie(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }
        public Locatie(int id, string name, string description, string xco)
        {
            ID = id;
            Name = name;
            Description = description;
            Xco = xco;
        }
        public Locatie(int id, string name, string description, string xco, string yco)
        {
            ID = id;
            Name = name;
            Description = description;
            Xco = xco;
            Yco = yco;
        }
    }
}
