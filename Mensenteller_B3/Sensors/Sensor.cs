using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensenTeller_B3.Sensors
{
    public class Sensor
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public int LocatieID { get; set; }


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
        public Sensor(int id, string name, int locatieId)
        {
            ID = id;
            Name = name;
            LocatieID = locatieId;
        }
    }
}
