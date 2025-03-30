using _06_homework_;
using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.Green;
            CreditCard creditCard = new CreditCard("Visa Platinum1", "1020304050607080", DateTime.Parse("20/12/2025"), 123, "Some additional info");
            Console.WriteLine(creditCard);
            Console.ResetColor();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\tTime           :: {DateTime.Now}");
            Console.WriteLine($"\tMessage        :: {ex.Message}");
            Console.WriteLine($"\tSource         :: {ex.Source}");
            Console.WriteLine($"\tTargetSite     :: {ex.TargetSite}");
            Console.ResetColor();
        }
    }
}