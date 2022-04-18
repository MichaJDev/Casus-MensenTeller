using Mensenteller_B3.Sensors.DrukSensors;
using Mensenteller_B3.Sensors.EntreeSensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensenteller_B3.Logic
{
    public class Statestieken
    {
        public int MaxPeopleIn { get; set; }
        public int MaxPeopleOut { get; set; }
        public int AveragePeopleIn { get; set; }

        public int DrukSensorsInUse { get; set; }
        EntreeSensorDAL esDal = new EntreeSensorDAL();
        DruksensorDAL dsDal = new DruksensorDAL();
        public void CollectMaxPeople()

        {
            foreach (EntreeSensor ds in esDal.ReadEntreeSensors())
            {
                MaxPeopleIn += ds.PeopleIn;
                MaxPeopleOut += ds.PeopleOut;

            }
        }

        public void CollectAverage()
        {
            CollectMaxPeople();
            int count = 0;
            foreach (EntreeSensor es in esDal.ReadEntreeSensors())
            {
                count++;
            }
            AveragePeopleIn = MaxPeopleIn / count;
        }

        public void CollectDrukSensorInUse()
        {
            foreach (DrukSensor ds in dsDal.ReadDrukSensor())
            {
                if (ds.InUse)
                {
                    DrukSensorsInUse += 1;
                }
            }
        }
    }
}