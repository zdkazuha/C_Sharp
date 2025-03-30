using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Class_intro
{
    // public - класс відкритий для інших збірок
    // internal - закритий для інших збірок, видимий для своєї збірки
    internal class Character // неявне успадкувався від суперктипу object
    {
        private string name = "NoName";
        private uint hp = 100;
        public string Name {
            //get
            //{
            //    return name;
            //}
            get => name;
            set
            {
                // value - значення яке ми будемо присвоювати 
                //if(value .Length == 0)
                //{
                //    name = "Test";
                //}
                //else
                //{
                //    name = value;
                //}
                if (!String.IsNullOrWhiteSpace(value)) // не порожній не null, не "    " or \t, \n
                    name = value;                
            }
        }
        public uint Damage { get; set; } //  авто властивість ккомпілятор створить поле

        public Character(string name, uint hp, uint damage)
        {
            //this.name = name;
            Name = name;
            this.hp = hp;
            this.Damage = damage;
        }
        public Character(string name = "None")
            :this(name,100,5)
        {
            
        }
        public void Print()
        {
            Console.WriteLine($"Character name   :: {Name}");
            Console.WriteLine($"Character hp     :: {hp}");
            Console.WriteLine($"Character damage :: {Damage}");
        }
        public uint KPD { get => Damage * hp;}
        public override string ToString()
        {
            return $"Name :: {Name,-10} HP :: {hp,-10} Damage :: {Damage,-10} KPD :: {KPD}";
        }
        public uint Hp { get; set; }
    }

    enum Position
    {
        None, Manager = 1,QA, Developer , Economist,Director
    }
    internal class  Employee
    {
        private static int lastid;
        public readonly int ID = ++lastid; // readonly поле тільуи для читання, встановлюєтсья 1 раз (в конструкторі або тут )
        public string Name { get; set; } = "NoName";
        public DateTime Birth { get; set; }
        public Position Position { get; set; }

        public static int LastId { get => lastid; }

        public static bool SamePosition(Employee em1, Employee em2) => em1.Position == em2.Position;

        static Employee() // без параметрів спрацює до першого використання класу(створення обєкту, виклик статичного методу чи властивості)
        {
            Console.WriteLine("\t\t Static ctor done!");
            lastid = new Random().Next(1, 10) * 1000;
        }
        public override string ToString() => $"ID :: {ID,-5} Name :: {Name,-10} Birth :: {Birth.ToShortDateString(),-15} Position :: {Position}";
        public int Age => (int)((DateTime.Today - Birth).TotalDays / 365.25);

    }
}
