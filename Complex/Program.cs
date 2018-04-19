using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(12.2345, 23.5332);
            Complex b = new Complex(15.6474, 27.7331);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a+b);
            Console.WriteLine(a*b);
            Console.WriteLine(a/b);

            Console.ReadKey();
        }
    }
}
