using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Learn_and_Understand_Interfaces
{
    interface ICustomList
    {
        Customer this[string firstName, string lastName] {
            get;
        }
    }
}
