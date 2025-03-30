using _15_homework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

internal class Program
{
    static void Task_1()
    {
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        List<int> arr = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"№{i + 1} Введіть число :: ");

            if (int.TryParse(Console.ReadLine(), out int number))
                arr.Add(number);
            else
            {
                Console.WriteLine("Ошибка! Введите корректное число.");
                i--;
            }
        }

        Console.WriteLine("\nВведённые числа:");
        foreach (var num in arr)
            Console.Write($"{num} \t");

        string fname = "../../../List.json";

        Console.WriteLine();
        Console.WriteLine("Введіть 1 - [фільтр простих чисел] 2 - [фільтр числа фібоначчі]");
        int tmp = int.Parse(Console.ReadLine()!);
        switch (tmp)
        {
            case 1:
                List<int> primeNumbers = new List<int>();
                foreach (int i in arr)
                {
                    if (!IsPrime(i))
                        primeNumbers.Add(i);
                }
                File.WriteAllText(fname, System.Text.Json.JsonSerializer.Serialize(primeNumbers));
                break;

            case 2:
                List<int> fib = new List<int>();
                if (arr.Count >= 3)
                {
                    fib.Add(arr[0]);
                    fib.Add(arr[1]);
                    for (int i = 2; i < arr.Count; i++)
                    {
                        int nextFib = (arr[i - 1] + arr[i - 2]);
                        if (arr[i] != nextFib)
                            fib.Add(arr[i]);

                    }
                    if (fib.Count == 0)
                    {
                        Console.WriteLine("Немає чисел фібоначі");
                        break;
                    }
                }
                File.WriteAllText(fname, System.Text.Json.JsonSerializer.Serialize(fib));
                break;

            default:
                Console.WriteLine("Введено невірне значення");
                break;
        }

        List<int> res = System.Text.Json.JsonSerializer.Deserialize<List<int>>(File.ReadAllText(fname))!;
        Console.WriteLine("\nРезультат:");
        Console.WriteLine(String.Join<int>("\n", res));
    }

    static void Task_2()
    {
        MusicAlbum musicAlbum = new MusicAlbum(new Song("Name", 0, "Style"), "Name Album", "Author", 2025, 60, "Recording Studio");

        string fname = "../../../musicAlbum.json";

        string json = JsonConvert.SerializeObject(musicAlbum);
        File.WriteAllText(fname, json);
        MusicAlbum tmp = JsonConvert.DeserializeObject<MusicAlbum>(File.ReadAllText(fname))!;
        Console.WriteLine(tmp);

        Console.WriteLine("\n\n");

        List<MusicAlbum> musicAlbums = new List<MusicAlbum>();
        musicAlbums.Add(tmp);
        musicAlbums.Add(tmp);

        string fname2 = "../../../musicAlbums.json";
        string json2 = JsonConvert.SerializeObject(musicAlbums);
        File.WriteAllText(fname2, json2);
        List<MusicAlbum> tmp2 = JsonConvert.DeserializeObject<List<MusicAlbum>>(File.ReadAllText(fname2))!;
        foreach (MusicAlbum album in tmp2)
        {
            Console.WriteLine(album);
            Console.WriteLine();
        }



    }
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //Task_1();

        //Task_2();

    }
}
