using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBoatApp
{
    class House
    {
        virtual public int SquareFeet { get; set; }
        public int NumBedrooms { get; set; }
        public int NumBathrooms { get; set; }
    }
}
