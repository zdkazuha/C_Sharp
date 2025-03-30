using _08_Extension_Method;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;

static class ExtensionInt
{
    public static uint CountDigit(this int number)
    {
        return (uint)Math.Abs(number).ToString().Length;
    }
}

static class ExtensionArray
{
    public static int SumPositiveElement(this int[] arr)
    {
         return Array.FindAll(arr, x => x > 0).Sum();
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        //int value = -1234566;
        //Console.WriteLine(value.CountDigit());

        //int[] arr = { 1, 2, 3, 4, 5, 6, -4 };
        //Console.WriteLine($"Sum :: {arr.SumPositiveElement()}");



        //



        //Duck duck = new Duck() { Weight = 8 };
        //Console.WriteLine(duck.Weight);
        //duck.Fly();
        //duck.Move();
        //duck.Swim();
        //Console.WriteLine();

        //Console.WriteLine("-------------- Duck IFky ------------- ");

        //IFly fly = duck;
        //Console.WriteLine(fly);
        //fly.Fly();
        //Console.WriteLine(fly.Speed);

        //Console.WriteLine("-------------- Duck IMove ------------- ");

        //IMove move = duck;
        //move.Move();
        //Console.WriteLine(move.Speed);

        //Console.WriteLine("-------------- Streamer Duck ------------- ");
        //StreamerDuck streamer = new StreamerDuck();
        //streamer.Fly();

        //IFly[] ducks = { duck, streamer };
        //foreach (var item in ducks)
        //{
        //    Console.WriteLine(item.Speed);
        //    item.Fly();
        //}



        //



        //Student student = new Student("Sasha",10,12,11,4,8,5,3,2,7);
        //Console.WriteLine($"Original :: {student} \n ");

        //Student clone = (student.Clone() as Student)!;

        //Console.WriteLine($"Original :: {student}");
        //Console.WriteLine($"Clone    :: {clone} \n ");

        //clone.Name = "Olia";

        //clone[0] = 2;
        //clone[1] = 3;

        //Console.WriteLine($"Original :: {student}");
        //Console.WriteLine($"Clone    :: {clone} \n ");




        //


        // Enumberable - це те що ми перелікочуємо
        // Enumberator - це те чим проходимо


        //int[] arr = { 4, 44, 5, 8, 10, 12, 15 };

        //var enArr = arr.GetEnumerator();
        //while (enArr.MoveNext())
        //{
        //    Console.Write($"{enArr.Current,-7}");
        //}
        //Console.WriteLine();


        //

        Shop shop = new Shop();
        Item apple = new Item() { Name = "Apple", Price = 30};
        Item orange = new Item() { Name = "Orange", Price = 60};
        Item bluberry = new Item() { Name = "Bluberry", Price = 40};
        Item plum = new Item() { Name = "Plum", Price = 70};

        shop.AddItem(apple);
        shop.AddItem(orange);
        shop.AddItem(bluberry);
        shop.AddItem(plum);

        Console.WriteLine("\n ------------------ IEnumberable getEnumerator() ----------------------------");
        foreach (var item in shop)
        {
            Console.WriteLine(item);
        }


        Console.WriteLine("\n ------------------ IEnumberable GetReverse() ----------------------------");
        foreach (var item in shop.GetReverse())
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\n ------------------ IEnumberable GetLinitProduct() ----------------------------");
        foreach (var item in shop.GetLinitProduct(60))
        {
            Console.WriteLine(item);
        }



    }
}