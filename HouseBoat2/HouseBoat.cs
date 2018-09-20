using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBoat2
{
    class HouseBoat : House, IBoat
    {
        private Boat MyBoat = new Boat();
        public void SetHeading(float heading)
        {
            MyBoat.SetHeading(heading);
        }
    }
}
