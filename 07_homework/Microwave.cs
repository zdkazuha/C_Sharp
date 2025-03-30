using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _07_homework
{
    internal class Microwave : Device
    {
        protected string name = "NoName", color = "NoColor";
        public string Name { get => name; set => name = value ?? "NoName"; }
        public string Color { get => color; set => color = value ?? "NoColor"; }

        protected int temperature;
        public int Temperature { get => temperature;
            set
            {
                if (value < 0)
                {
                    throw new Exception($"Not correct value :: {value}");
                }
                temperature = value;
            } 
        }
        public Microwave(string name,string color, int temperature) 
        {
            Name = name;
            Color = color;
            Temperature = temperature;
        }

        public override void Sound()
        {
            Console.WriteLine("Microwave sound :: Peak peak peak ");
        }
        public override void Show()
        {
            Console.WriteLine($"Name device :: {name,-10}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Name :: {name,-10} Color :: {color,-10} Heating temperature :: {temperature,-10} Sound :: {"Peak peak peak",-10}");
        }
    }
}
