using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_IComparer
{
    public partial class Form1 : Form
    {
        private Car[] Cars;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            // Make some Cars

            Cars = new Car[]
            {
                new Car("Ferrari LaFerrari\t", 1400000,217, 1000),
                new Car("Zenvo ST1\t", 1200000,233, 1104),
                new Car("Lamborghini Veneno\t", 4500000, 220, 740),
                new Car("Aston Martin One-77\t", 1400000, 220, 750),
                new Car("W Motors Lykan Hypersport\t", 3400000, 240, 770),
                new Car("Koenigsegg One:1\t", 2500000, 273, 1340),
                new Car("Ferrari F60 America\t", 2500000, 225, 730),
                new Car("Pagani Huayra\t", 1400000, 238, 620),
                new Car("Masonry Vivere Bugatti Veyron\t", 3400000, 254, 1200),
                new Car("Koenigsegg CCXR Trevita\t", 4800000, 254, 1004),

            };

            foreach (Car car in Cars)
            {
                car.AddToListView(carListView);
            }

            carListView.ListViewItemSorter = new CarNameComparer();
            rbName.Checked = true;


        }

        //private void DisplayCars()
        //{
        //    carsListBox.Items.Clear();

        //    foreach (Car car in Cars)
        //    {
        //        carsListBox.Items.Add(car.ToString());
        //    }
        //}

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            //CarNameComparer comparer = new CarNameComparer();
            //Array.Sort(Cars, comparer);
            //DisplayCars();
            //MessageBox.Show("Event Fires");

            //carListView.ListViewItemSorter = new CarNameComparer();
        }

        private void rbPrice_CheckedChanged(object sender, EventArgs e)
        {
            //CarPriceComparer comparer = new CarPriceComparer();
            //Array.Sort(Cars, comparer);
            ////DisplayCars();
        }

        private void rbName_Click(object sender, EventArgs e)
        {
            carListView.ListViewItemSorter = new CarComparer(CarComparer.SortByValues.Name);
        }

        private void rbPrice_Click(object sender, EventArgs e)
        {
            carListView.ListViewItemSorter = new CarComparer(CarComparer.SortByValues.Price);
        }

        private void cbSortDecending_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSortDecending.Checked)
            {
                carListView.Sorting = SortOrder.Descending;
            }
            else
            {
                carListView.Sorting = SortOrder.Ascending;
            }

            carListView.Sort();
        }

        private void rbTopSpeed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbHorsepower_Click(object sender, EventArgs e)
        {
            carListView.ListViewItemSorter = new CarComparer(CarComparer.SortByValues.Horsepower);
        }

        private void rbTopSpeed_Click(object sender, EventArgs e)
        {
            carListView.ListViewItemSorter = new CarComparer(CarComparer.SortByValues.TopSpeed);
        }
    }
}
