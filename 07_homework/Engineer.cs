using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_homework
{
    internal class Engineer : Worke
    {
        public Engineer() {}
        public override void Print()
        {
            Console.WriteLine($"Posada :: {this.GetType().Name,-10}");
        }
    }
}
