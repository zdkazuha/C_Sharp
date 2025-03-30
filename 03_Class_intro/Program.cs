using _03_Class_intro;

internal class Program
{
    static class AreaShapes
    {
        const double PI = 3.14;
        public static double TrianArea(double height, double side)
        {
            return 0.5 * height * side;
        }
        public static double CircleArea(double radius)
        {
            return PI * Math.Pow(radius, 2);
        }
    }
    private static void Main(string[] args)
    {
        Character character = new Character("Elf",100,10);
        character.Print();
        Console.WriteLine(character);
        Character ch_2 = new Character(damage:15, name:"Mag", hp: 150);
        Console.WriteLine(ch_2);
        ch_2.Name = "Kind Elf";
        Console.WriteLine(ch_2);

        Character ch_3 = new Character() { Name = "Ranger", Damage = 10, Hp = 200 };
        Console.WriteLine(ch_3);


        Console.WriteLine("Main started .....");
        Console.WriteLine($"Last id :: {Employee.LastId}");

        Employee employee = new Employee() { Name = "Denis", Birth = DateTime.Parse("30/10/2000"), Position = Position.Manager };
        Console.WriteLine(employee);
        Console.WriteLine($"Age :: {employee.Age}");

        Employee employee1 = new Employee()
        {
            Name = "Ivan",
            Birth = new DateTime(2005, 12, 29),
            Position = Position.QA,
        };

        Console.WriteLine(employee1);
        Console.WriteLine($"Age :: {employee1.Age}");

        Console.WriteLine($"Same position {Employee.SamePosition(employee1,employee)}"); ;
        Console.WriteLine($"Last id :: {Employee.LastId}");


        Console.WriteLine(AreaShapes.TrianArea(10, 15));

    }
} 