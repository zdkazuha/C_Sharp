using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _07_homework
{
    internal class Kettle : Device
    {
        protected string name = "NoName";
        public string Name { get => name; set => name = value ?? "NoName"; }

        protected int temperature;
        public int Temperature { get=> temperature;
            set
            {
                if(value < 0)
                {
                    throw new Exception($"Not correct value :: {value}");
                }
                temperature = value;
            } 
        }
        public Kettle(string name ,int temperature)
        {
            Name = name;
            Temperature = temperature;
        }
        public override void Sound()
        {
            Console.WriteLine("Kittle sound :: Whistl whistl whistl ");
        }
        public override void Show()
        {
            Console.WriteLine($"Name device :: {name,-10}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Name :: {name,-10} Heating temperature :: {Temperature,-10} Sound :: {"Whistl whistl whistl",-10}");
        }
    }
}
