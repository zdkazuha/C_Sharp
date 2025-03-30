using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_homework
{
    internal class SportCar :Car
    {
        public SportCar(string name) 
            : base(name) {}

        public SportCar(string name,int speed)
            :base(name,speed) {}
    }
}
