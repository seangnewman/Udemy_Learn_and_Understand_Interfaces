using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Udemy_Learn_and_Understand_Interfaces
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ICustomList list = new CustomerList();
            //Customer rod = list["Rod", "Stephens"];

            ITree<Person> personTree = new BinaryTree();
            List<Person> children = personTree.GetChildren(null);
            string result = personTree.DoSomething<string>();
        }
    }
}
