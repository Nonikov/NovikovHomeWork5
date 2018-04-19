using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Complex
    {
        double x;
        double y;

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        
        public double Real
        {
            get { return x; }
            set { x = value; }
        }

        public double Imaginary
        {
            get { return y; }
            set { y = value; }
        }

        public override string ToString()
        {
            return $"( {x.ToString("F2")} : {y.ToString("F2")} )";
        }

        public static Complex operator + (Complex a, Complex b)
        {
            return new Complex(a.x + b.x, a.y + b.y);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.x - b.x, a.y - b.y);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.x * b.x - a.y * b.y, a.x * b.x + a.y * b.y);
        }

        public static Complex operator /(Complex a, Complex b)
        {
            return new Complex((a.x*b.x + a.y*b.y)/(b.x*b.x + b.y*b.y) , (b.x * a.y - a.x * b.y) / (b.x * b.x + b.y * b.y));
        }
    }
}
