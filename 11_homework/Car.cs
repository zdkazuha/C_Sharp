using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_homework
{
    internal abstract class Car
    {
        private static Random random = new Random();  

        public string Name { get; set; }
        public int Speed { get; set; }
        public int Position { get; set; } = 0;

        public event Action<string> OnFinish;

        protected Car(string name)
        {
            Name = name;
            Speed = random.Next(10, 30);
        }

        protected Car(string name, int speed)
        {
            Name = name;
            Speed = speed; 
        }

        public void Move()
        {
            Position += Speed;
            Speed = random.Next(10, 30);
            Console.WriteLine($"{Name} рухається! Поточна позиция: {Position}");

            if (Position >= 100)
            {
                OnFinish?.Invoke(Name);
            }
            
        }
    }
}
