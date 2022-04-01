using Casus_Blok3_MensenTeller.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Blok3_MensenTeller.Ruimtes
{
     public class Ruimte
    {
        public int ID{ get; set; }
        public string Name { get; set; }
        public List<Zone> Zones { get; set; }

        public Ruimte()
        {

        }
        public Ruimte(int id)
        {
            ID = id;
        }
        public Ruimte(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public Ruimte(int id, string name, List <Zone> zones)
        {
            ID = id;
            Name = name;
            
        }
    }
}
