using _13_homework;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Game game = new Game("Гравец 1","Гравец 2","Гравец 3", "Гравец 4");

        game.Play();
    }
}