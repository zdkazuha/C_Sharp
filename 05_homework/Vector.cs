using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace _05_homework
{
    internal class Vector
    {
        double x, y;

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    default: return -1;
                }

            }
            set
            {
                switch (index)
                {
                    case 0: this.x = value; break;
                    case 1: this.y = value; break;
                }
            }

        }

        public override string ToString()
        {
            return $"{x}/{y}";
        }

        public static double Length_(Vector a)
        {
            return Math.Sqrt(a.x * a.x + a.y * a.y);
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.x + b.x, a.y + b.y);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.x - b.x, a.y - b.y);
        }

        public static Vector operator *(Vector a, double b)
        {
            return new Vector(a.x * b, a.y * b);
        }        
        public static double operator *(Vector a, Vector b)
        {
            return (a.x * a.y + a.y * b.y);
        }

        public static bool operator ==(Vector a, Vector b)
        {
            if (a is null || b is null) return false;
            return a.x == b.x && a.y == b.y;
        }
        public static bool operator !=(Vector a, Vector b)
        {
            return !(a == b);
        }
        public static Vector operator ++(Vector a)
        {
            Vector vector = new Vector(1, 1);
            return a + vector;
        }
        public static Vector operator --(Vector a)
        {
            Vector vector = new Vector(1, 1);
            return a - vector;
        }
        public static Vector operator -(Vector a)
        {
            return new Vector(-a.x, -a.y);
        }
        public static bool operator true(Vector a)
        {
            return a.x != 0;
        }
        public static bool operator false(Vector a)
        {
            return a.x == 0 && a.y == 0;
        }
        public static explicit operator double(Vector a)
        {
            return Length_(a);
        }        
        public static implicit operator Vector(double a)
        {
            return new Vector(a, 0);
        }
    }
}
