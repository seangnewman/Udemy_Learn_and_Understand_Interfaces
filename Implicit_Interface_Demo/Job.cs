using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Interface_Demo
{
    class Job : IShedulable
    {
        public DateTime StartTime {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }
        public DateTime StopTime {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }
    }
}
