using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBoatApp
{
    interface IBoat
    {
         
        EngineTypes EnginType { get; set; }
        int NumMasts { get; set; }
        bool HasGps { get; set; }

        int SquareFeet { get; set; }

    }
}
