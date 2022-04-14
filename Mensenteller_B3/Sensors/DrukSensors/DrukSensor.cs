using MensenTeller_B3.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensenteller_B3.Sensors.DrukSensors
{
    public class DrukSensor : Sensor
    {
        public int EntryId { get; set; }
        public int SensorId { get; set; }
        public bool InUse { get; set; }
        public string TimeStamp { get; set; }

        

        public DrukSensor()
        {

        }

        public DrukSensor(int entryid)
        {
            EntryId = entryid;
        }

        public DrukSensor(int entryid, int sensorid)
        {
            EntryId = entryid;
            SensorId = sensorid;
        }

        public DrukSensor(int entryid, int sensorid, bool inuse)
        {
            EntryId = entryid;
            SensorId = sensorid;
            InUse = inuse;
        }

        public DrukSensor(int entryid, int sensorid, bool inuse, string timestamp)
        {
            EntryId = entryid;
            SensorId = sensorid;
            InUse = inuse;
            TimeStamp = timestamp;
        }

        public DrukSensor(int sensorid, bool inuse, string timestamp)
        {
            SensorId = sensorid;
            InUse = inuse;
            TimeStamp = timestamp;
        }
    }
}