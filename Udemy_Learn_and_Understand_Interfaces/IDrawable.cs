using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Udemy_Learn_and_Understand_Interfaces
{
    interface IDrawable:IComparable, ICloneable
    {
        int Width { get; set; }
        int Height { get; set; }
        Rectangle Bounds { get; }
        bool isHighlighted { set; }

    }
}
