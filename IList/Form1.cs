using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IList
{
    public partial class Form1 : Form
    {
        private string[] AnimalArray;
        private List<string> AnimalList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AnimalArray = new string[]
            {
                "Aardvark",
                "Badger",
                "Camel",
                "Dormouse"
            };

            AnimalList = new List<string>(AnimalArray);
        }

        // Display values in a ListBox
        private void DisplayValues(ListBox lst, IEnumerable<string> values)
        {
            lst.Items.Clear();

            foreach (string value in values)
            {
                lst.Items.Add(value);
            }
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            AnimalArray.Randomize();
            DisplayValues(listBox1, AnimalArray);
            AnimalList.Randomize();
            DisplayValues(listBox2, AnimalList);


        }
    }
}
