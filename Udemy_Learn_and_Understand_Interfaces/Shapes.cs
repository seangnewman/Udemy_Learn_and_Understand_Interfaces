using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Learn_and_Understand_Interfaces
{
    class Shapes : IDrawable
    {
        public int Width { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Rectangle Bounds => throw new NotImplementedException();

        public bool IsHighlighted { set => throw new NotImplementedException(); }

        public event EventHandler Moved;

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public void Draw(Graphics gr)
        {
            throw new NotImplementedException();
        }
    }
}
