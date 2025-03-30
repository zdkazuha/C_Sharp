using System.Reflection.Metadata.Ecma335;

internal class Program
{

    static int[] CreateArr(int size)
    {
        return new int[size];
    }

    static void FillRandArr(int[] arr, int left = -10, int right = 10)
    {
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(left, right);
        }
    }

    static void Print(int[] arr, string prompt = "")
    {
        Console.Write(prompt);
        foreach (var item in arr)
        {
            Console.Write($"{item,-10}");
        }
        Console.WriteLine();
    }

    static void Swap(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i += 2)
        {
            int temp = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = temp;
        }
    }

    static int Positive(int[] arr)
    {
        return Array.Find(arr, x => x > 0);
    }

    static int EvenElements(int[] arr)
    {
        return arr.Count(a => a % 2 == 0);
    }

    static int FirstIndexSeven(int[] arr)
    {
        int index = Array.FindIndex(arr, a => a % 7 == 0);
        return index;
    }


    private static void Main(string[] args)
    {
        int[] arr = CreateArr(5);
        FillRandArr(arr);
        Print(arr, "Print :: ");
        Swap(arr);
        Print(arr, "Print :: ");
        Console.WriteLine($"First positive element  :: {Positive(arr)}");
        Console.WriteLine($"Even element            :: {EvenElements(arr)}");
        Console.WriteLine($"First Index Seven       :: {FirstIndexSeven(arr)}");

    }

}