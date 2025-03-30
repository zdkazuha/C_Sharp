using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_homework
{
    internal class Car : Device
    {
        protected string name = "NoName", brand = "NoBrand";
        public string Name { get => name; set => name = value ?? "NoName"; }
        public string Brand { get => brand; set => brand = value ?? "NoBrand"; }

        protected int speed;
        public int Speed { get => speed;
            set 
            {
                if (value < 0)
                {
                    throw new Exception($"Not correct value :: {value}");
                }
                speed = value;
            } 
        }
        public Car(string name, string brand, int speed)
        {
            Name = name;
            Brand = brand;
            Speed = speed;
        }

        public override void Sound()
        {
            Console.WriteLine("Car sound :: Peep peep peep ");
        }
        public override void Show()
        {
            Console.WriteLine($"Name device :: {name,-10}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Name :: {name,-10} Brand :: {brand,-10} Speed :: {speed,-10} Sound :: {"Peep peep peep",-10}");
        }
    }
}
