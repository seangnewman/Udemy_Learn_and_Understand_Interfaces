using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Learn_and_Understand_Interfaces
{
    class CustomerList:ICustomList
    {
        public Customer this[string firstName, string lastName]
        {
            get
            {
                return new Customer(firstName, lastName);
            }
        }
    }
}
