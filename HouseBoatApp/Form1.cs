using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseBoatApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HouseBoat houseBoat = new HouseBoat();
            int sf1 = houseBoat.SquareFeet;

            House house = houseBoat;
            int sf2 = house.SquareFeet;

            IBoat boat = houseBoat;
            
        }
    }
}
