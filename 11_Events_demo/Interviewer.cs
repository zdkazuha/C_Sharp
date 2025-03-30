using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Events_demo
{
    internal class Interviewer
    {
        public string Name { get; set; }

        // метод під делегат Positiondelegate
        public void Dosomething(string desc)
        {
            Console.WriteLine($"Interviwer {Name} notified about {desc}");
        }
    }
}
