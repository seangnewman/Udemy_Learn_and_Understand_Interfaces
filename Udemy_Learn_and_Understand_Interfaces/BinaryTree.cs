using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Learn_and_Understand_Interfaces
{
    class BinaryTree : ITree<Person>
    {
        public void AddChiild(Person child)
        {
            throw new NotImplementedException();
        }

        public T2 DoSomething<T2>()
        {
            throw new NotImplementedException();
        }

        public List<Person> GetChildren(Person parent)
        {
            throw new NotImplementedException();
        }

        public Person GetParent(Person Child)
        {
            throw new NotImplementedException();
        }
    }
}
