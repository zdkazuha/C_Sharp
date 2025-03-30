internal class Program
{
    static int[] FilterArray(int[] arr, Predicate<int> func)
    {
        int[] Arr = new int[0];

        foreach (var item in arr)
        {
            if(func(item))
            {
                Array.Resize(ref Arr, Arr.Length + 1);
                Arr[Arr.Length - 1] = item;
            }
        }
        return Arr;
    }

    static int[] isFib(int[] arr)
    {
        int[] newArr = new int[0];
        int a = 0, b = 1, c = 0;
        foreach (var item in arr)
        {
            while (c < item)
            {
                c = a + b;
                a = b;
                b = c;
            }
            if(c == item)
            {
                Array.Resize(ref newArr, newArr.Length + 1);
                newArr[newArr.Length - 1] = item;
            }
        }
        return newArr ;
    }

    static int[] PrimeNumber(int[] arr)
    {
        int[] newArr = new int[0];
        int counter = 0;
        foreach (var item in arr)
        {
            for (int i = 1; i <= item; i++)
            {
                if(item % i == 0)
                {
                    counter++;
                }
            }
            if(counter == 2)
            {
                Array.Resize(ref newArr, newArr.Length + 1);
                newArr[newArr.Length - 1] = item;
            }
            counter = 0;
        }
        return newArr;
    }

    static void CurrentTime()
    {
        Console.WriteLine($"Current time :: {DateTime.Now.ToString("HH:mm:ss")}");
    }

    static void CurrentDate()
    {
        Console.WriteLine($"Current date :: {DateTime.Now.ToString("y:M:d")}");
    }

    static void CurrentDayOfWeek()
    {
        Console.WriteLine($"Current day of week :: {DateTime.Now.ToString("dddd")}");
    }

    static double TriangleArea(double b, double h)
    {
        return 0.5 * b * h;
    }

    static double RectangleArea(double a, double b)
    {
        return a * b;
    }

    private static void Main(string[] args)
    {
        Action act = CurrentTime;
        act += CurrentDate;
        act += CurrentDayOfWeek;

        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Even numbers:      " + String.Join(", ", FilterArray(arr, e => e % 2 == 0)));
        Console.WriteLine("Odd numbers:       " + String.Join(", ", FilterArray(arr, e => e % 2 != 0)));

        Console.WriteLine("Prime numbers:     " + String.Join(", ", PrimeNumber(arr)));

        Console.WriteLine("Fibonacci numbers: " + String.Join(", ", isFib(arr)));

        Console.WriteLine();

        act();

        Console.WriteLine();

        Func<double,double,double> func = TriangleArea;
        Console.WriteLine($"Area of a triangle        :: {func.Invoke(5, 10)}");

        func = RectangleArea;
        Console.WriteLine($"the area of the rectangle :: {func.Invoke(5, 10)}");

    }
}