using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBoatApp
{
    enum EngineTypes
    {
        None, 
        Inboard,
        Outboard, 
        SternDrive
    }
    class Boat
    {
        public EngineTypes EnginType { get; set; }
        public int NumMasts { get; set; }
        public bool HasGps { get; set; }
    }
}
