using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensenteller_B3.Sensors.EntreeSensors
{
    public class EntreeSensor
    {
        public int EntryID { get; set; }

        public int SensorID { get; set; }
        public string Name { get; set; }
        public int PeopleIn { get; set; }
        public int PeopleOut { get; set; }
        public string TimeStamp { get; set; }

        public EntreeSensor()
        {
        }
        public EntreeSensor(int _id)
        {
            EntryID = _id;
        }
        public EntreeSensor(int _id, int _sensorId)
        {
            EntryID = _id;
            SensorID = _sensorId;
        }
        public EntreeSensor(int _id,int _sensorId, string _name)
        {
            EntryID = _id;
            SensorID = _sensorId;
            Name = _name;
        }
        public EntreeSensor(int _id, int _sensorId, string _name, int _peopleIn, int _peopleOut)
        {
            EntryID = _id;
            Name = _name;
            PeopleIn = _peopleIn;
            PeopleOut = _peopleOut;
        }

        public EntreeSensor(int _id, int _sensorId, string _name, int _peopleIn, int _peopleOut, string _timeStamp)
        {
            EntryID = _id;
            SensorID = _sensorId;
            Name = _name;
            PeopleIn = _peopleIn;
            PeopleOut = _peopleOut;
            TimeStamp = _timeStamp;
        }

        public EntreeSensor(int _sensorId, string _name, int _peopleIn, int _peopleOut, string _timeStamp)
        {
            SensorID = _sensorId;
            Name = _name;
            PeopleIn = _peopleIn;
            PeopleOut = _peopleOut;
            TimeStamp = _timeStamp;
        }
    }
}