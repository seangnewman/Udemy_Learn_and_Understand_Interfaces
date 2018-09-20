using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Interface_Demo
{
    interface IShedulable
    {
         DateTime StartTime { get; set; }
         DateTime StopTime { get; set; }
    }
}
