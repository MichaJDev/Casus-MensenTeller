
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MensenTeller_B3.Sensors;

namespace MensenTeller_B3.Zones
{
    public class Zone
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Sensor> Sensors { get; set; }

        public int BedrijvenId { get; set; }
        public Zone()
        {

        }
        public Zone(int id)
        {
            ID = id;
        }
        public Zone(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public Zone(int id, string name, List <Sensor> sensors)
        {
            ID = id;
            Name = name;
            Sensors = sensors;
        }
        public Zone(int id, string name, List<Sensor> sensors, int bedrijvenId)
        {
            ID = id;
            Name = name;
            Sensors = sensors;
            BedrijvenId = bedrijvenId;
        }
    }
}
