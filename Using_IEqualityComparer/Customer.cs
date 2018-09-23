using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_IEqualityComparer
{
    class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Customer(string name, string address)
        {
            Name = name;
            Address = address;

        }

        public override string ToString()
        {
            return String.Format("{0}, {1}", Name, Address);
        }
    }
}
