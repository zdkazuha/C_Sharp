using System;
namespace _09_homework;
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int[,,] arr = new int[3, 3, 3];

            Vector vector = new Vector(arr);
            Vector vector2 = new Vector(arr);

            vector.Print("Vector 1:");

            vector.Fill(5);
            Console.WriteLine();
            vector.Print("Vector 1 (fill 5):");

            vector2 = vector * 5;
            vector2.Print("Vector 2 (fill 5 * 5):");

            var v3 = vector + vector2;
            v3.Print("Vector 3 (vector 1 + vector 2):");

            Vector v4 = vector2 - vector;
            v4.Print("Vector 4 (vector 2 - vector 1):");

        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
        }
    }
}