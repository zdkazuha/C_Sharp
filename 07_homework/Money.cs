using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_homework
{
    internal abstract class Money
    {
        protected int grn;
        protected int cop;
        public int Grn { get=>grn; 
            set
            {
                if(value < 0)
                {
                    throw new Exception($"Not correct value {value}");
                }
                grn = value;
            }
        }
        public int Cop
        {
            get => cop;
            set
            {
                if (value < 0)
                {
                    throw new Exception($"Not correct value {value}");
                }
                cop = value;
            }
        }
        public Money(int grn ,int cop)
        {
            Cop = cop;
            Grn = grn;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Grn :: {grn,-10} Cop :: {cop,-10}");
        }

    }


}
