using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Extension_Method
{
    internal class Duck : IFly, IMove, ISwim
    {
        //public int Speed => 3;

        public int Weight { get; set; }
        int IFly.Speed => 5;
        int IMove.Speed => 3;


        public virtual void Fly()
        {
            Console.WriteLine($"Duck can fly with {((IFly)this).Speed}");
        }

        public void Move()
        {
            Console.WriteLine($"Duck with weight {Weight} can walk with {((IMove)this).Speed}");
        }

        public void Swim()
        {
            Console.WriteLine("Duck can swim");

        }
    }
}
