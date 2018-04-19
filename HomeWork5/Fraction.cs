using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Fraction
    {
        int ch;
        int zn;

        public int Chislitel
        {
            get { return ch; }
            set { ch = value; }
        }
        public int Znamenatel
        {
            get { return zn; }
            set
            {
                if (value == 0) throw new DivideByZeroException("Delit nelzya");
                else zn = value;
            }
        }
        public Fraction(int ch, int zm)
        {
            Chislitel = ch;
            Znamenatel = zm;
        }

        public override string ToString()
        {
            return Chislitel > Znamenatel ? $"{Chislitel / Znamenatel} + {Chislitel % Znamenatel}/{Znamenatel}" : $"{Chislitel}/{Znamenatel}";
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.ch * b.ch, a.zn * b.zn);
        }

        public static Fraction operator *(Fraction a, int b)
        {
            return new Fraction(a.ch * b, a.zn);
        }

        public static Fraction operator *(int a, Fraction b)
        {
            return new Fraction(a * b.ch, b.zn);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction(a.ch * b.zn, a.zn * b.ch);
        }

        public static Fraction operator /(Fraction a, int b)
        {
            return new Fraction(a.ch, a.zn * b);
        }

        public static Fraction operator /(int a, Fraction b)
        {
            return new Fraction(b.ch, a* b.zn);
        }
    }
}
