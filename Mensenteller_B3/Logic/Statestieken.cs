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

        EntreeSensorDAL esDal = new EntreeSensorDAL();

        public void CollectMaxPeople(string timestamp)

        {
            foreach (EntreeSensor ds in esDal.EntreeSensors)
            {
                if (ds.TimeStamp == timestamp)
                {
                    MaxPeopleIn += ds.PeopleIn;
                    MaxPeopleOut += ds.PeopleOut;
                }
            }
        }

        public void CollectAverage(string timestamp)
        {
            CollectMaxPeople(timestamp);
            int count = 0;
            foreach (EntreeSensor es in esDal.EntreeSensors)
            {
                if (timestamp == es.TimeStamp)
                {
                    count++;
                }
            }
            AveragePeopleIn = MaxPeopleIn / count;
        }

        public void Stoplicht()
        {
            // wanneer variable toegekend is kan deze methode gebruikt worden

            //if ( < 30)
            //{
            //    Console.WriteLine("Laat kleur groen zien");
            //}
            //else if ( > 30 &&  < 60)
            //{
            //    Console.WriteLine("Laat Kleur geel zien");
            //}
            //else
            //{
            //    Console.WriteLine("Laat kleur rood zien");
            //}
        }
    }
}