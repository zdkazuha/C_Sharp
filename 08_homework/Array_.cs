using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_homework
{
    class Array_ : IOutput, ICals, IOutput2, ICals2
    {
        public int[] Array { get; set; } 

        public Array_(params int[] array)
        {
            Array = (int[])array.Clone();  
        }

        public void Show()
        {
            Console.WriteLine(ToString());  
        }

        public void ShowInfo(string info)
        {
            Console.Write(info);
            Console.Write($" {ToString()} \n");
        }

        public override string ToString()
        {
            StringBuilder n = new StringBuilder();
            foreach (var item in Array)
            {
                n.Append(item).Append(" ");
            }
            return n.ToString(); 
        }

        public int Less(int valueToCompare)
        {
            int res = 0;
            foreach (var item in Array)
            {
                if (item < valueToCompare)
                {
                    res++;
                }
            }
            return res;
        }

        public int Gerater(int valueToCompare)
        {
            int res = 0;
            foreach (var item in Array)
            {
                if (item > valueToCompare)
                {
                    res++;
                }
            }
            return res;
        }

        public void ShowEven()
        {
            StringBuilder n = new StringBuilder();
            foreach (var item in Array)
            {
                if(item % 2 == 0)
                { 
                    n.Append(item).Append(" ");
                }
            }
            Console.WriteLine(n);
        }

        public void ShowOdd()
        {
            StringBuilder n = new StringBuilder();
            foreach (var item in Array)
            {
                if (item % 2 != 0)
                {
                    n.Append(item).Append(" ");
                }
            }
            Console.WriteLine(n);
        }

        public int CountDisit()
        {
            int res = 0;
            foreach (var item in Array)
            {
                if (EqualToValue(item) == 1)
                {
                    res++;
                }
            }
            return res;
        }

        public int EqualToValue(int valueToCompare)
        {
            int res = 0;
            foreach (var item in Array)
            {
                if (item == valueToCompare)
                {
                    res++;
                }
            }
            return res;
        }
    }
}
