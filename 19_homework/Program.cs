using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.OutputEncoding = Encoding.UTF8;

        //string pattern = @"^\d{4}$";
        //int[] arr = { 1000, 2000, 3000, 4000, 5000, 6000, 7000, 645 };
        //string pattern = @"^[a-zA-Z]{3}\d{3}[a-zA-Z]{3}\d{3}$"; 
        //string pattern = @"^[A-Z]{3}$"; 
        string pattern = @"^(19\d{2}|20\d{2})$";

        string pattern1 = @"\+38-0\d{2}-\d{5}23";
        string pattern2 = @"\+38-0\d{2}-\d*00\d*";

        string[] arr2 = { "asd123zxc456", "bnm567hjk890", "test123fail" }; 
        string[] arr3 = { "WWW", "FFF", "FFF","fff","ldkldFWL" }; 
        int[] arr4 = { 1800,1900,2000,2100,2099 }; 
        string[] arr5 = { "380842668437", "380944688187" };

        string[] phoneNumbers =
{
            "+38-067-1234523",
            "+38-050-9876523",
            "+38-093-4567001",
            "+38-067-1234007",
            "+38-073-0001234",
            "+38-097-5555555"
        };

        var regex = new Regex(pattern);

        List<string> list = new List<string>();
        foreach (var item in arr4)
        {
            if (regex.IsMatch(item.ToString()))
                list.Add(item.ToString());
        }

        Console.WriteLine(string.Join("\t", list));

        Console.WriteLine("\n\nНомери, які закінчуються на '23':");
        var regex1 = new Regex(pattern1);
        foreach (var number in phoneNumbers)
        {
            if (regex1.IsMatch(number))
                Console.WriteLine(number);
        }


        Console.WriteLine("\nНомери, що містять '00':");
        var regex2 = new Regex(pattern2);
        foreach (var number in phoneNumbers)
        {
            if (regex2.IsMatch(number))
                Console.WriteLine(number);
        }



    }
}