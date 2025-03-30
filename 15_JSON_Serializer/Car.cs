using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _15_Serializers
{
    // 1) клас для серіалізації - Public
    // 2) cеріалізувати можна - public поля, властивості
    // 3) явний коструктор по замовчуванню
    public class Engine
    {
        public double Power { get; set; } // auto-prop
        public Engine(double power)
        {
            Power = power;
        }
        public Engine()
            : this(1.0) { }

        public override string ToString()
        {
            return $"Engine power : {Power}";
        }
    }
    public class Car
    {
        //[XmlAttribute("ID")]
        //[XmlIgnore]
        public int id;
        private string brand;
        public string Brand { get => brand; set => brand = value ?? "Nobrand"; }
        public Engine Engine { get; set; }
        public Car(int id, string brand, double power)
        {
            this.id = id;
            Brand = brand;
            Engine = new Engine(power);
        }
        public Car()
            : this(0, "NoBrand", 1.0) { }

        public override string ToString()
        {
            return $"ID:{id}. Car brand : {brand,-15} : {Engine,-15}";
        }
    }
}
