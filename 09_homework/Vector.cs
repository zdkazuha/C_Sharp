using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _09_homework
{
    struct Vector
    {
        private int[,,] arr;

        public int[,,] Arr
        {
            get => arr;
            set => arr = value;
        }

        public Vector(int[,,] arr) => this.arr = arr;

        public void Print(string a)
        {
            Console.WriteLine(a);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int q = 0; q < arr.GetLength(2); q++)
                    {
                        Console.Write($"{arr[i, j, q]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        public void Fill(int a)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int q = 0; q < arr.GetLength(2); q++)
                    {
                        arr[i, j, q] = a;
                    }
                }
            }
        }

        public static Vector operator *(Vector v, int a)
        {
            var newArr = new int[v.Arr.GetLength(0), v.Arr.GetLength(1), v.Arr.GetLength(2)];

            for (int i = 0; i < newArr.GetLength(0); i++)
                for (int j = 0; j < newArr.GetLength(1); j++)
                    for (int q = 0; q < newArr.GetLength(2); q++)
                        newArr[i, j, q] = v.Arr[i, j, q] * a;

            return new Vector(newArr);
        }

        public static Vector operator +(Vector a, Vector b)
        {
            if (!AreDimensionsEqual(a, b)) throw new ArgumentException("The sizes of the arrays must match!");

            var newArr = new int[a.Arr.GetLength(0), a.Arr.GetLength(1), a.Arr.GetLength(2)];

            for (int i = 0; i < newArr.GetLength(0); i++)
                for (int j = 0; j < newArr.GetLength(1); j++)
                    for (int q = 0; q < newArr.GetLength(2); q++)
                        newArr[i, j, q] = a.Arr[i, j, q] + b.Arr[i, j, q];

            return new Vector(newArr);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            if (!AreDimensionsEqual(a, b)) throw new ArgumentException("The sizes of the arrays must match!");

            var newArr = new int[a.Arr.GetLength(0), a.Arr.GetLength(1), a.Arr.GetLength(2)];

            for (int i = 0; i < newArr.GetLength(0); i++)
                for (int j = 0; j < newArr.GetLength(1); j++)
                    for (int q = 0; q < newArr.GetLength(2); q++)
                        newArr[i, j, q] = a.Arr[i, j, q] - b.Arr[i, j, q];

            return new Vector(newArr);
        }

        private static bool AreDimensionsEqual(Vector a, Vector b) =>
            a.Arr.GetLength(0) == b.Arr.GetLength(0) &&
            a.Arr.GetLength(1) == b.Arr.GetLength(1) &&
            a.Arr.GetLength(2) == b.Arr.GetLength(2);
    }
}
