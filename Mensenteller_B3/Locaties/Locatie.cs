using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensenteller_B3.Locaties
{
    public class Locatie
    {
        public int ID { get; set; }
        public string Name { get; set; }


        public int ZoneId { get; set; }

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


        public Locatie(int id, string name, int zoneid)
        {
            ID = id;
            Name = name;
            ZoneId = zoneid;
        }
    }
}
