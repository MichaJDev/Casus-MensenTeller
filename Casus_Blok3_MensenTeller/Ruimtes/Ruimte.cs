using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Blok3_MensenTeller.Ruimtes
{
     public class Ruimte
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Zone> Zones { get; set; }

        public Ruimte(int id, string name, List <Zone> zones)
        {
            Id = id;
            Name = name;
            
        }
    }
}
