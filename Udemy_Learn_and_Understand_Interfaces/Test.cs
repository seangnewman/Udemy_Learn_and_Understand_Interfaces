using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Learn_and_Understand_Interfaces
{
    class Test
    {
       void TestEvents()
        {
            //IAccount cust = new Customer();
            //cust.OverDrawn += Cust_OverDrawn;
            //cust.Overdrawn2 += Cust_OverDrawn2;
            //cust.OverDrawn3 += Cust_OverDrawn3;
            //cust.Overdrawn4 += Cust_OverDrawn4;
        }

        private bool Cust_OverDrawn4(decimal arg1, string arg2)
        {
            throw new NotImplementedException();
        }

        private void Cust_OverDrawn(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Cust_OverDrawn2(decimal balance, string name)
        {
            throw new NotImplementedException();
        }

        private void Cust_OverDrawn3(decimal balance, string name)
        {
            throw new NotImplementedException();
        }

        void TestDrawEvent()
        {
            IDrawable drawObject = new Shapes();
            drawObject.Moved += Object_Moved;
        }

        private void Object_Moved(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
