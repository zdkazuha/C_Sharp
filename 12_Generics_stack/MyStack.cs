using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Generics_stack
{
    internal class MyStack<T> : Istack<T>
    {
        T[] stack;
        const int Empty = -1;
        int top = Empty;
        public int Capacity => stack.Length; // reserve

        private bool Full() => top == Capacity - 1;

        public MyStack(int capacity = 5)
        {
            if(capacity < 0) capacity = 5;
            stack = new T[capacity];
            
        }
        public int Count => top + 1;

        public T peek()
        {
            return stack[top]; // exception
        }

        public void pop()
        {
            if (top != Empty)
                top--;
        }

        public void push(T value)
        {
            if(Full())
                Array.Resize(ref stack, stack.Length + 5);
            stack[++top] = value;
        }
    }
}
