using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNum
{
    [Serializable]
    class Complex
    {
        private int x, y;

        public Complex() { }

        public Complex(int x, int y)
        {
             this.x = x;
             this.y = y;
        }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public static Complex operator *(Complex a, Complex b)
        {
            Complex c = new Complex();

            c.X = a.X * b.X;
            c.Y = a.Y * b.Y;
            return c;
        }

        public override string ToString()
        {
            return x + "+" + y + "i";
        }

    }
}