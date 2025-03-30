internal class Program
{
    private static void Main(string[] args)
    {
        string fname = "../../../data.txt";

        //string line = "Test - line Текстовий рядок";
        //double valueD = 258.32;
        //int valueI = -542145;
        //DateTime today = DateTime.Now;
        //int[] arr = { 65, 66, 67, 68, 69 };

        //using (StreamWriter sw = new StreamWriter(fname))
        //{
        //    sw.WriteLine(line);
        //    sw.WriteLine(valueD);
        //    sw.WriteLine($"Value -- {valueI}");
        //    sw.WriteLine(today);
        //    sw.WriteLine(arr.Length);
        //    foreach (int i in arr)
        //    {
        //        sw.WriteLine(i);
        //    }
        //}

        // 1 way
        Console.WriteLine($"Content ReadAllText \n{File.ReadAllText(fname)}");

        // 2 way
        Console.WriteLine("\n" + new string('*',50) + "\n");
        var res = File.ReadAllLines(fname);
        Console.WriteLine($"Content ReadAllLines \n");
        foreach( string line in res )
        {
            Console.WriteLine(line);
        }

        // 3 way 
        Console.WriteLine("\n" + new string('*', 50) + "\n");
        using (StreamReader sr = new StreamReader(fname))
        {
            Console.WriteLine($"Content ReadToEnd \n {sr.ReadToEnd()}");
        }

        // 4 way
        Console.WriteLine("\n" + new string('*', 50) + "\n");
        string lines;
        using (StreamReader sr = new StreamReader(fname))
        {
            Console.WriteLine($"Content (line by line) \n ");
            while((lines = sr.ReadLine()) != null)
            {
                Console.WriteLine(lines);
            }
        }

        // 5 way
        Console.WriteLine("\n" + new string('*', 50) + "\n");
        int symbol;
        using (StreamReader sr = new StreamReader(fname))
        {
            Console.WriteLine($"Content (char by char) \n ");
            while ((symbol = sr.Read()) != -1)
            {
                Console.WriteLine((char)symbol);
            }
        }
    }
}