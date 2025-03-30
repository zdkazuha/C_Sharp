using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Generics_stack
{
    internal interface Istack<T>
    {
        void pop();
        void push(T value);

        T peek();

        int Count { get;}
    }
}
