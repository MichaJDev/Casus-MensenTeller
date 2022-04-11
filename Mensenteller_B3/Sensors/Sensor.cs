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

        public int PeopleIn { get; set; }
        
        public int PeopleOut { get; set; }

        public string ResetTimeStamp { get; set; }

        public Sensor (int id, string name, string resetTimeStap)
        {
            ID = id;
            Name = name;
            PeopleIn = 0;
            PeopleOut = 0;
            ResetTimeStamp = resetTimeStap;  
        }

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
