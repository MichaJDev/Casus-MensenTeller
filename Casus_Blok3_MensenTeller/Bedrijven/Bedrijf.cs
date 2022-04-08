
using Casus_Blok3_MensenTeller.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Blok3_MensenTeller.Bedrijven
{
    internal class Bedrijf
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Zone> Zones { get; set; }


        public Bedrijf()
        {

        }

        public Bedrijf(int id)
        {
            Id = id;

        }

        public Bedrijf(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Bedrijf(int id, string name, List<Zone> zones)
        {
            Id = id;
            Name = name;
            Zones = zones;

        }


    }
}
