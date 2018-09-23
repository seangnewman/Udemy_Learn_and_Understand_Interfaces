using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_ICloneable
{
    class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Address(string street, string city, string state, string zip )
        {
            Street = street;
            City = city;
            State = state;
            Zip = zip;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1} {2} {3}", Street, City, State, Zip);
        }

        public Address Clone()
        {
            return (Address)this.MemberwiseClone();
        }
    }
}
