using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Blok3_MensenTeller.Sensors
{
    public class Sensor
    {

        public int ID { get; set; }
        public string Name { get; set; }

        public Sensor()
        {

        }
        public Sensor(int id)
        {
            ID = id;
        }

        public Sensor(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
