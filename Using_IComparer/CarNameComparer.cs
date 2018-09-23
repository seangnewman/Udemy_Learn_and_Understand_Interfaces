using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Using_IComparer
{
    class CarNameComparer :   IComparer
    {
        //public int Compare(Car car1, Car car2)
        //{
        //    return car1.Name.CompareTo(car2.Name);
        //}

        public int Compare(object x, object y)
        {
            ListViewItem item1 = x as ListViewItem;
            ListViewItem item2 = y as ListViewItem;
            Car car1 = item1.Tag as Car;
            Car car2 = item2.Tag as Car;

            int result =  car1.Name.CompareTo(car2.Name);

            if(item1.ListView.Sorting == SortOrder.Ascending)
            {
                return result;
            }

            if (item1.ListView.Sorting == SortOrder.Descending)
            {
                return -result;
            }

            return 0;
        }
    }
}
