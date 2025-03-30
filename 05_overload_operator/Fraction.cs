using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_overload_operator
{
    partial class Fraction
    {
        private int num;
        private int denom;
        public int Num { get => num; set => num = value; }
        public int Denom { get => denom; set => denom = value != 0 ? value : -1; }
        public override string ToString()
        {
            return $"{num}/{denom}";
        }
        public Fraction(int num, int denom)
        {
            this.num = num;
            Denom = denom;
        }

        public int this[int index] 
        { 
            get
            {
                switch (index)
                {
                    case 0: return num;
                    case 1: return denom;
                    default: return -1;
                }

            }
            set
            {
                switch(index)
                {
                    case 0: num = value; break;
                    case 1: Denom = value; break;
                    default: break;
                }
            }

        }
    }

    /*
        +,-,/,%,   --. неявно перевантаження +=, -= ,*= , /= , %= 
        == i !=; < i <, >= i <=;
        true i false
        implisit, explisit
        ++i, --i
     */
    partial class Fraction
    {
        public static Fraction operator +(Fraction a, Fraction b) 
        {
            int num = a.num * b.denom + b.num * a.denom;
            int denom = a.denom * b.denom;
            return new Fraction(num, denom);
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            if (a is null || b is null) return false;
            return a.num == b.num && a.denom == b.denom;
        }        
        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }
        public static bool operator true(Fraction a)
        {
            return a.num != 0;
        }
        public static bool operator false(Fraction a)
        {
            return a.num == 0;
        }
        public static Fraction operator ++(Fraction a)
        {
            Fraction fraction = new Fraction(1, 1);
            return a + fraction;
        }
        public static explicit operator int(Fraction a)
        {
            return a.num / a.denom;
        }
        public static implicit operator double(Fraction a)
        {
            return (double)a.num / (double)a.denom;
        }
    }
}
