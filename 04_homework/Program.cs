using _04_homework;

internal class Program
{
    private static void Main(string[] args)
    {
        WebSite site = new WebSite();
        Console.WriteLine(site);
        Console.WriteLine();
        site.Input("Steam", "https:/steam", "Game store", "345.234.12.52");
        Console.WriteLine(site);
        Console.WriteLine();

        Magazine magazine = new Magazine();
        Console.WriteLine(magazine);
        Console.WriteLine();
        magazine.Input("Magazine olimp", DateTime.Parse("6/1/2025"),"Autor Genri Robertson", 380556339145,"Magazine@gmai.com");
        Console.WriteLine(magazine);
        Console.WriteLine();

    }
}