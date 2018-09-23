using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_IComparer
{
    class Car
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int TopSpeed { get; set; }
        public int Horsepower { get; set; }

        public Car( string name, decimal price, int topSpeed, int horsepower)
        {
            Name = name;
            Price = price;
            TopSpeed = topSpeed;
            Horsepower = horsepower;
        }

        public override string ToString()
        {
            return String.Format("{0}\t{1}\t{2}\t{3}", Name, Price.ToString("C"), TopSpeed.ToString(), Horsepower.ToString());
        }

        public void AddToListView(ListView listview)
        {
            ListViewItem item = listview.Items.Add(Name);
            item.SubItems.Add(Price.ToString("C"));
            item.SubItems.Add(TopSpeed.ToString());
            item.SubItems.Add(Horsepower.ToString());
            item.Tag = this;
        }
    }
}
