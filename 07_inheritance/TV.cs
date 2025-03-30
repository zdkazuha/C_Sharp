using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_inheritance
{
    internal class TV : Device
    {
        public int Diagonal { get; set; } = 42;
        public TV(string brand = "Nobrand",int year = 2000,int diagonal = 42)
            :base(brand,year)
        {
            Diagonal = diagonal;
        }
        public  sealed override void Print()
        {
            //base.Print();
            Console.WriteLine($"{this.GetType().Name,-10} Brand :: {brand,-10} Year :: {Year,-10} Weidth :: {Weight,-10} Price :: {Price,-10} Diagonal :: {Diagonal,-10}");

        }
        public void NextChannel()
        {
            Console.WriteLine($"\n {new string('#', 50)}\n\t Method NextChannel work \n {new string('#', 50)}");
        }
    }
}
