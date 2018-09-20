using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Learn_and_Understand_Interfaces
{
    interface IAccount
    {
        event EventHandler<OverDrawnEventArgs> OverDrawn;
        event OverDrawnEventHandler Overdrawn2;
        event Action<decimal, string> OverDrawn3;
        event Func<decimal, string, bool> Overdrawn4;
    }
}
