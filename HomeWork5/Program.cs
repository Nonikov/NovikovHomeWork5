using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(3, 4);
            Fraction b = new Fraction(3, 7);

            Fraction c = a * b;
            Console.WriteLine(c);
            Console.WriteLine(b/a);

            Console.ReadKey();
        }
    }
}
