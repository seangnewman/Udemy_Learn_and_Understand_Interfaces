using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseBoat2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HouseBoat houseboat = new HouseBoat();
            houseboat.SetHeading(180);
            IBoat iboat = houseboat;
            iboat.SetHeading(90);
            House house = houseboat;
            house.SetTemperature(72);
        }
    }
}
