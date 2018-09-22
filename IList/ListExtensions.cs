using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IList
{
    public static class ListExtensions
    {
        private static Random Rand = new Random();
        public static void Randomize<T>(this IList<T> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                int j = Rand.Next(i, list.Count);
                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }
    }

    
}
