using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Learn_and_Understand_Interfaces
{
    interface ITree<T> where T : new()
    {
        void AddChiild(T child);

        List<T> GetChildren(T parent);

        T GetParent(T Child);

        T2 DoSomething<T2>();
    }
}
