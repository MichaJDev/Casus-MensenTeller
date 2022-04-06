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
        
        public void Reset(DateTime _resetper)
        {
            ResetTimeStamp = Helper.DateToStamp(_resetper);
            PeopleIn = 0;
            PeopleOut = 0;

        }
        public void GenerateFakeData(double _factorIn, double _factorOut, int _default, int _maxIn, int _maxOut)
        {
            Random rnd = new Random();
            var c_in = Math.Round(rnd.Next(0, _default) * _factorIn, 0);
            var c_out = Math.Round(rnd.Next(0, _default) * _factorOut, 0);
            PeopleIn = (int)Math.Min(c_in, _maxIn);
            PeopleOut = (int)Math.Min(c_out, _maxOut);
        }
    }
}
