

internal class Program
{
    static void BadSwap( int x, int y) // x, y - value type, прийшла копія значення
    {
        var tmp = x;
        x = y;
        y = tmp;
    }
    // ref,out - пердача параметрів за посиланням
    // ref = фактичний параметр який має має бути проаніціалізований!!!
    // out = фактичний параметр який має може бути не проаніціалізований!!! параметр для збереження результату

    static void Swap(ref int x, ref int y) // x, y - value type, прийшла копія значення
    {
        var tmp = x;
        x = y;
        y = tmp;
    }

    static void SumTwo(int a, int b, out int res)
    {
        res = a + b;
    }

    private static void Main(string[] args)
    {
        // value type (int,double.float.long,bo,char,enum,struct) - stack

        // reference type (class,interface,string,builderstring,delegate,array) - heap


        //int a = 5, b = 6;
        //Console.WriteLine($"a = {a,-10} b = {b}");
        //Swap(ref a, ref b);
        //Console.WriteLine($"a = {a,-10} b = {b}");
        //int res;
        //SumTwo(a, b, out res);
        //Console.WriteLine(res);


        int[] arr = new int[5] { 1, 2, 3, 4, 5 };
        int[] arr2 = { 10, 20, 30, 40, 50 };
        //int[] arr3; // null

        Print(arr, "Print Array #1 :: ");
        Print(arr2, "Print Array #2 :: ");


        Console.Write("Enter number of element :: ");
        int size = 10; //int.Parse(Console.ReadLine());
        int[] arr3 = new int[size];
        Fill(arr3, -10, 10);
        Console.WriteLine();
        Print(arr3, "Print rand array      :: ");
        PushBack(ref arr3, 222);
        Print(arr3, "Print array after push:: ");

        int value = 222;/*int.Parse(Console.ReadLine());*/
        // бібліотека linq - ммметоди розгирення для роботи з масивом
        if (arr3.Contains(value))
        {
            Console.WriteLine($"value {value} was found");
        }
        else
        {
            Console.WriteLine($"value {value} not found");
        }
        Console.WriteLine($"number of element is positive :: {arr3.Count(IsPositive)}");
        int index = Array.IndexOf(arr3,value);
        if (index != -1)
        {
            Console.WriteLine($"Valvu {value} = index {index}");
            int LastIndex = Array.LastIndexOf(arr3,value);
            Console.WriteLine($"Valvu {value} = last index {LastIndex}");
        }
        Console.WriteLine();
        int firtPositive = Array.FindIndex(arr3,IsPositive);
        if (firtPositive != -1)
        {
            Console.WriteLine($"Valvue positive {value} = index {firtPositive}");
            int lastIndex = Array.FindLastIndex(arr3, IsPositive);
            Console.WriteLine($"Valvu {value} = last index {lastIndex}");
        }
        //  (formal params list) => {return ... ;};
        index = Array.FindIndex(arr3, (int e) => { return e % 3 == 0; });

        Console.WriteLine($"position firt number % 3 --> {index}");
        int[] events = Array.FindAll(arr3, e => e % 2 == 0);
        Print(events, "Print event element :: ");
        Console.WriteLine();
        Console.WriteLine(Array.TrueForAll(arr3, IsPositive));
        Console.WriteLine(Array.Exists(arr3, IsPositive));

        Print(arr3, "Print rand array      :: ");

        Array.Sort(arr3);
        Print(arr3, "Print rand array      :: ");
        Array.Reverse(arr3);
        Print(arr3, "Print rand array      :: ");
        Console.WriteLine(arr3.Sum());
        Console.WriteLine(arr3.Min());
        Console.WriteLine(arr3.Max());
        Console.WriteLine(arr3.Average());

        Console.WriteLine();
        string[] colors = { "red","yellow","Gold", "aque", "purple"};
        Print(colors, "Print colors :: ");
        Array.Sort(colors,(s1,s2)=> s1.Length.CompareTo(s2.Length));
        Print(colors, "Print colors :: ");
    }

    static bool IsPositive(int a)
    {
        return a > 0;
    }

    static void PushBack(ref int[] arr, int value)
    {
        //int[] tmp = new int[arr.Length + 1];
        ////for (int i = 0; i < arr.Length; i++)
        ////{
        ////    tmp[i] = arr[i];
        ////}
        //arr.CopyTo(tmp, 0);

        //tmp[tmp.Length - 1] = value;
        //arr = tmp;

        Array.Resize(ref arr, arr.Length+1);
        arr[arr.Length-1] = value;

    }

    static void Fill(int[] arr, int min = 0, int max = 50) // aaray - ref type
    {
        //foreach (var item in arr) // error - only read
        //{
        //    item = rnd.Next(min, max);
        //}

        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(min, max);
        }
    }

    static void Print<T>(T[] arr, string prompt = "")
    {
        Console.Write(prompt);
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.Write($"{arr[i],-10}");
        //}
        
        foreach (var item in arr)
        {
                Console.Write($"{item,-10}");
        }
        Console.WriteLine();
    }
}

