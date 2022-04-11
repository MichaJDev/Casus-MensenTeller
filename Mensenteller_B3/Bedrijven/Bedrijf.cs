
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MensenTeller_B3.Zones;

namespace Mensenteller_B3.Bedrijven
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
