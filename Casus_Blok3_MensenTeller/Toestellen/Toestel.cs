using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casus_Blok3_MensenTeller.Sensors;

namespace Casus_Blok3_MensenTeller.Toestellen
{
    public class Toestel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Sensor Sensor { get; set; }

        public Toestel()
        {

        }
        public Toestel(int id)
        {
            ID = id;
        }
        public Toestel(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public Toestel(int id, string name, Sensor sensor)
        {
            ID = id;
            Name =name; 
            Sensor = sensor;
        }
    }
}
