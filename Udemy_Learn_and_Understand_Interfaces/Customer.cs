using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Learn_and_Understand_Interfaces
{
    delegate void OverDrawnEventHandler(decimal balance, string name);

    class Customer : IAccount
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }


        public event EventHandler<OverDrawnEventArgs> OverDrawn;
        public event OverDrawnEventHandler Overdrawn2;
        
        public event Action<decimal, string> OverDrawn3;
        public event Func<decimal, string, bool> Overdrawn4;
    }
}
