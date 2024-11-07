using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Question2.Types
{
    public class Bus: Vehicle
    {
        public List<ParkingTypes> AcceptableParkingTypes = new List<ParkingTypes>() { ParkingTypes.Lot };

        public bool CompactSpot = false;
    }
}
