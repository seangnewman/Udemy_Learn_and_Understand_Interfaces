using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBoatApp
{
    class HouseBoat : House, IBoat
    {
        public EngineTypes EnginType {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }
        public int NumMasts {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }
        public bool HasGps {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }

        public override int SquareFeet { get; set; }
    }
}
