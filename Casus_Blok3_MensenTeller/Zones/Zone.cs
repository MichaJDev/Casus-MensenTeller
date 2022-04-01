using Casus_Blok3_MensenTeller.Toestellen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Blok3_MensenTeller.Zones
{
    public class Zone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Toestel> Toestellen { get; set; }

        public Zone(int id, string name, List <Toestel> toestellen)
        {
            Id = id;
            Name = name;
        }
    }
}
