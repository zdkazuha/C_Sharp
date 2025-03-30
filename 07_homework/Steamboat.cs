using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_homework
{
    internal class Steamboat : Device
    {
        protected string name = "NoName";
        public string Name { get => name; set => name = value ?? "NoName"; }

        protected int speed, length, width;

        public int Length { get=> length;
            set
            {
                if (value < 0)
                {
                    throw new Exception($"Not correct value :: {value}");
                }
                length = value;
            }
        }
        public int Width
        {
            get => width;
            set
            {
                if (value < 0)
                {
                    throw new Exception($"Not correct value :: {value}");
                }
                width = value;
            }
        }

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
        public Steamboat(string name,int length,int width, int speed)
        {
            Name = name;
            Width = width;
            Length = length;
            Speed = speed;
        }

        public override void Sound()
        {
            Console.WriteLine("Steamboat sound :: Choo choo choo ");
        }
        public override void Show()
        {
            Console.WriteLine($"Name device :: {name,-10}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Name :: {name,-10} Length :: {length,-10} Width :; {width,-10} Speed :: {speed,-10} Sound :: {"Choo choo choo",-10}");
        }
    }
}
