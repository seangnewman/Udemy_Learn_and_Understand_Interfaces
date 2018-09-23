using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Using_IComparer
{
    class CarComparer : IComparer
    {
        public enum SortByValues
        {
            Name,
            Price,
            TopSpeed,
            Horsepower

        }

        public SortByValues SortBy { get; set; }
        public CarComparer(SortByValues sortBy)
        {
            SortBy = sortBy;
        }

        public int Compare(object x, object y)
        {


            
            ListViewItem item1 = x as ListViewItem;
            ListViewItem item2 = y as ListViewItem;
            Car car1 = item1.Tag as Car;
            Car car2 = item2.Tag as Car;

            int result = 0;

            switch (SortBy)
            {
                case SortByValues.Name:
                    result = car1.Name.CompareTo(car2.Name);
                    break;
                case SortByValues.Price:
                    result = car1.Price.CompareTo(car2.Price);
                    break;
                case SortByValues.TopSpeed:
                    result = car1.TopSpeed.CompareTo(car2.TopSpeed);
                    break;
                case SortByValues.Horsepower:
                    result = car1.Horsepower.CompareTo(car2.Horsepower);
                    break;
                default:
                    result = 0;
                    break;
            }



            if (item1.ListView.Sorting == SortOrder.Ascending)
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
