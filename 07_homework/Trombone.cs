using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_homework
{
    internal class Trombone : Musical_instrument
    {
        public Trombone(string name, string sound, string description, string history)
            : base(name, sound, description, history)
        {

        }

        public override void Desc()
        {
            Console.WriteLine($"Description :: {Description}");
        }

        public override void History()
        {
            Console.WriteLine($"Historyм    :: {History_}");
        }

        public override void Show()
        {
            Console.WriteLine($"Name        :: {Name}");
        }

        public override void Sound_()
        {
            Console.WriteLine($"Sound       :: {Sounds}");
        }
    }
}
