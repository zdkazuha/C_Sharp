using _08_homework;

internal class Program
{
    private static void Main(string[] args)
    {
        Array_ arr = new Array_(new int[] { 1, 2, 3, 4, 5 , 6, 7, 8, 9, 10});

        arr.Show();
        Console.WriteLine();
        arr.ShowInfo("Array :: ");

        Console.WriteLine();

        Console.WriteLine($"The number of elements is greater than 5 :: {arr.Less(5)}");

        Console.WriteLine($"The number of elements is less than 5    :: {arr.Gerater(5)}");

        Console.WriteLine();

        arr.ShowOdd();

        Console.WriteLine();

        arr.ShowEven();

        Console.WriteLine();

        Console.WriteLine($"The number of values is 5 :: {arr.EqualToValue(5)}");

        Console.WriteLine();

        Console.WriteLine($"Number of unique values :: {arr.CountDisit()}");

    }
}