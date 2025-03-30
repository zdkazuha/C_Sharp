//using System.Numerics;
using _05_homework;
internal class Program
{
    private static void Main(string[] args)
    {
        double d = 35.8;

        Vector vector1 = new Vector(5, 10);
        Vector vector2 = new Vector(10.0, 5);
        Vector vector3 = new Vector(0, 0);
        Vector vector4 = d;


        Console.WriteLine($"Vector 1 :: {vector1}");
        Console.WriteLine();
        Console.WriteLine($"Vector 2 :: {vector2}");        
        Console.WriteLine();
        Console.WriteLine($"Vector 3 :: {vector3}");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine($"Vector {vector1} + Vector {vector2} = {vector1 + vector2}");
        Console.WriteLine();
        Console.WriteLine($"Vector {vector1} - Vector {vector2} = {vector1 - vector2}");
        Console.WriteLine();
        Console.WriteLine($"Vector {vector1} * 2.5 = {vector1 * 2.5}");
        Console.WriteLine();
        Console.WriteLine($"Vector {vector1} * Vector {vector2} = {vector1 * vector2}");
        Console.WriteLine();
        Console.WriteLine($"Vector {vector1} == Vector {vector2} = {vector1 == vector2}");
        Console.WriteLine();
        Console.WriteLine($"Vector {vector1} != Vector {vector2} = {vector1 != vector2}");
        Console.WriteLine();
        Console.WriteLine($"Vector {vector1}++  = {vector1++}");
        Console.WriteLine();
        Console.WriteLine($"Vector ++{vector1}  = {++vector1}");
        Console.WriteLine();
        Console.WriteLine($"Vector {vector1}--  = {vector1--}");
        Console.WriteLine();
        Console.WriteLine($"Vector --{vector1}  = {--vector1}");
        Console.WriteLine();
        Console.WriteLine($"Vector -{vector1}  = {-vector1}");
        Console.WriteLine();
        Console.WriteLine($"Vector {vector1}  = {(vector1 ? "True" : "False")}");
        Console.WriteLine();
        Console.WriteLine($"Vector {vector3}  = {(vector3 ? "True" : "False")}");
        Console.WriteLine();
        Console.WriteLine($"Vector {vector2}[0] = {vector2[0]}");
        Console.WriteLine();
        Console.WriteLine($"Vector {vector2}[1] = {vector2[1]}");
        Console.WriteLine();
        Console.WriteLine($"Vector {vector1} += Vector {vector2} = {vector1 += vector2}");
        Console.WriteLine();
        Console.WriteLine($"Vector {vector1} -= Vector {vector2} = {vector1 -= vector2}");
        Console.WriteLine();
        Console.WriteLine($"Vector {vector1} *= 2.5 = {vector1 *= 2.5}");
        Console.WriteLine();        
        Console.WriteLine($"Vector (double){vector1} = {(double)vector1:f2}");        
        Console.WriteLine();        
        Console.WriteLine($"Double {d} = Vector {vector4}");        
    }
}