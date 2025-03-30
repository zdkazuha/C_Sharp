using _06_Class_intro;
using System.Data;
using System.Net.Http.Headers;

internal class Program
{
    static int DivideNumber(int a, int b)
    {
        int result = 0;
        try
        {
            result = a / b;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Inner Exception -->" + ex.Message);
            throw;
        }
        return result;
    }
    private static void Main(string[] args)
    {

        //Matrix matrix = new Matrix(2, 2);
        //Console.WriteLine(matrix);
        //Console.WriteLine("\n" + new string('=',40) + "\n");
        //matrix[0,0] = 10;
        //matrix[0,1] = 20;
        //matrix[1,0] = 30;
        //matrix[1,2] = 40;
        //Console.WriteLine(matrix);


        //int a, b, result;

        //while (true)
        //{
        //    try
        //    {

        //        Console.WriteLine("Enter two number :: ");

        //        a = int.Parse(Console.ReadLine()!);
        //        b = int.Parse(Console.ReadLine()!);
        //        result = DivideNumber(a, b);
        //        Console.WriteLine($"{a} / {b} = {result}");
        //        break;
        //    }
        //    catch (DivideByZeroException ex)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine($"\t Message        :: {ex.Message}");
        //        Console.WriteLine($"\t HelpLink       :: {ex.HelpLink}");
        //        Console.WriteLine($"\t Sourse         :: {ex.Source}");
        //        Console.WriteLine($"\t TargetSite     :: {ex.TargetSite}");
        //        foreach (var key in ex.Data.Keys)
        //        {
        //            Console.WriteLine($"{key} --> {ex.Data[key]}");
        //        }
        //        Console.ResetColor();
        //    }
        //    catch(Exception ex)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine($"\t Message        :: {ex.Message}");
        //        Console.ResetColor();
        //    }
        //    finally
        //    {
        //        Console.ForegroundColor= ConsoleColor.Green;
        //        Console.WriteLine("Finally");
        //        Console.ResetColor();
        //    }
        //    Console.WriteLine("Finnaly");

        Product product = new Product();
        try
        {
            //product.Name = "black bread";
            product.Name = "bread";
            product.DateIn = DateTime.Parse("16/1/2025");
        }
        catch (BadDateProductException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\t Message        :: {ex.Message}");
            Console.WriteLine($"\t Error date     :: {ex.errorDate}");
            Console.WriteLine($"\t Sourse         :: {ex.Source}");
            Console.WriteLine($"\t TargetSite     :: {ex.TargetSite}");
            Console.ResetColor();
        }
        catch(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\t Message        :: {ex.Message}");
            Console.WriteLine($"\t HelpLink       :: {ex.HelpLink}");
            Console.WriteLine($"\t Sourse         :: {ex.Source}");
            Console.WriteLine($"\t TargetSite     :: {ex.TargetSite}");
            foreach (var key in ex.Data.Keys)
            {
                Console.WriteLine($"{key} --> {ex.Data[key]}");
            }
            Console.ResetColor();
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Name product : {product.Name,-15} Date : {product.DateIn}");
        Console.ResetColor();
    }
}