using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensenteller_B3.Sensors.EntreeSensors
{
    public class EntreeSensor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PeopleIn { get; set; }
        public int PeopleOut { get; set; }
        public string TimeStamp { get; set; }

        public EntreeSensor()
        {
        }
        public EntreeSensor(int _id)
        {
            ID = _id;
        }
        public EntreeSensor(int _id, string _name)
        {
            ID = _id;
            Name = _name;
        }
        public EntreeSensor(int _id, string _name, int _peopleIn, int _peopleOut)
        {

        }

        public EntreeSensor(int _id, string _name, int _peopleIn, int _peopleOut, string _timeStamp)
        {

        }
    }
}