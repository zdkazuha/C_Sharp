using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_homework
{
    internal class Truck : Car
    {
        public Truck(string name)
           : base(name) { }

        public Truck(string name,int speed)
            :base(name,speed) {}
    }
}
