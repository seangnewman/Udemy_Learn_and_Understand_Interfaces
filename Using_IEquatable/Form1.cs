using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_IEquatable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<Author, string> dict = new Dictionary<Author, string>();

            Author author1 = new Author("Sean", "Newman");
            Author author2 = new Author("Sean", "Newman");
            Author author3 = new Author("Ann", "Archer");

            dict.Add(author1, "1");
            dict.Add(author3, "1");
           // dict.Add(author2, "1");

        }
    }
}
