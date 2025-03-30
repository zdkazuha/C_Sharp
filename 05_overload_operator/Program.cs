using _05_overload_operator;
using System.Security.Cryptography.X509Certificates;

internal class Program
{

    class Persona
    {
        public string Name { get; set; }
        public string LastName { get; set; }

    }

    private static void Main(string[] args)
    {
        //string str = null;
        ////int value null; 
        //Console.WriteLine(default(string) == null);
        //Console.WriteLine(default(int[]) == null );
        //Console.WriteLine(default(int));
        //Console.WriteLine(default(bool));
        ////Console.WriteLine(value);


        ////str = "Lorem ipsum";
        ////if(str == null)
        ////{
        ////    Console.WriteLine("Default text");
        ////}
        ////else
        ////{
        ////    {
        ////        Console.WriteLine(str);
        ////    }
        ////}

        //Console.WriteLine();
        //// ++i;
        //// !true
        //// -i;
        ////Бінарний оператор
        //// a + b + c 
        //// a == b
        ////Тернарний
        //// s ? b : c
        //Console.WriteLine(str != null ? str : "Default text");
        //// ??
        //Console.WriteLine(str??"Default text");
        //str = null;
        ////Persona persona = new Persona() { Name = null };
        ////Persona persona = new Persona() { Name = "Denis" };
        //Persona persona = null;
        //Console.WriteLine(persona?.Name ?? "NoneName");
        //str = "Lorem ipsum";
        //Console.WriteLine(str?.Length ?? -1);
        //Console.WriteLine(str?.Replace('m','@') ?? "Error");

        //Nullable<int> value = null;
        //Console.WriteLine(value.GetValueOrDefault());
        //int?number = null;

        //int[] arr = null;
        //Console.WriteLine(arr?[0] ?? -1);

        //arr??=new int[6] { 1,2,3,4,5,6 };
        //Console.WriteLine(arr?[0] ?? -1);

        //



        Fraction one = new Fraction(1, 2);
        Fraction two = new Fraction(2, 3);
        Console.WriteLine($"One :: {one}; \t Two :: {two}");
        Console.WriteLine();

        Console.WriteLine($"Num :: {one[0]}; \t Denom :: {one[1]}");

        //

        Console.WriteLine($"{one} + {two} = {one + two}");
        Console.WriteLine($"{one} == {two} = {one == two}");
        Console.WriteLine($"{one} != {two} = {one != two}");
        Console.WriteLine(one ? "True" : "False");
        one[0] = 0;
        Console.WriteLine(one ? "True" : "False");
        Console.WriteLine(one++);
        Console.WriteLine(one);
        Console.WriteLine(++one);
        
        Console.WriteLine($"{one} ==> int() {(int)one}");
        //Console.WriteLine($"{two} ==> int() {(int)two}");

        double value = two;
        value = new Fraction(1, 2);
        Console.WriteLine($"Result explicit ==> {(double)two}");


    }
}