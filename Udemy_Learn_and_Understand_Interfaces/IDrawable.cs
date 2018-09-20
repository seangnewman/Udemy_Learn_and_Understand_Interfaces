using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Udemy_Learn_and_Understand_Interfaces
{
    interface IDrawable:IComparable, ICloneable
    {
        int Width { get; set; }
        int Height { get; set; }
        Rectangle Bounds { get; }
        bool IsHighlighted { set; }

        void Draw(Graphics gr);


        //Define an event
        event EventHandler Moved;

    }
}
