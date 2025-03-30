internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        // Є Офіціант Кухар та Бармен.        
        //task1();
        //task2();о
        //task3();
        //task4();

    }
    static void task1()
    {
        Console.Write("Ведіть посаду працівника             :: ");
        string position = Console.ReadLine();
        Console.Write("Ведіть кількість відпрацованих годин :: ");
        int number;
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Помилка: Введено некоректну кількість годин.");
            return;
        }

        switch (position)
        {
            case "Офіціант":
                Console.WriteLine("Сума :: " + (number * 8));
                break;
            case "Кухар":
                Console.WriteLine("Сума :: " + (number * 12));
                break;
            case "Бармен":
                Console.WriteLine("Сума :: " + (number * 16));
                break;
            default:
                Console.WriteLine("Невідома посада.");
                break;
        }
    }

    static void task2()
    {
        Console.Write("Ведіть значення першого числа :: ");
        int number1;
        if (!int.TryParse(Console.ReadLine(), out number1))
        {
            Console.Write("Помилка: Введено некоректну кількість годин.");
            return;
        }
        if (number1 < 0)
        {
            Console.WriteLine("Значення має бути додатнім :: ");
        }
        Console.Write("Ведіть значення другого числа :: ");
        int number2;
        if (!int.TryParse(Console.ReadLine(), out number2))
        {
            Console.Write("Помилка: Введено некоректну кількість годин.");
            return;
        }
        if (number2 < 0)
        {
            Console.WriteLine("Значення має бути додатнім :: ");
        }

        if (number1 > number2)
        {
            int tmp = number1;
            number1 = number2;
            number2 = tmp;
        }

        for (int i = number1; i <= number2; i++)
        {

            for (int f = 0; f < i; f++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }

    static void task3()
    {
        int spaces = 0, digits = 0, letters = 0, punctuation = 0;
        char symbol;

        Console.WriteLine("Вводьте символи. Для завершення введіть крапку ('.')");

        while (true)
        {
            symbol = (char)Console.Read();

            if (symbol == '.')
                break;

            if (char.IsWhiteSpace(symbol) && symbol != '\n' && symbol != '\r')
                spaces++;
            if (char.IsDigit(symbol))
                digits++;
            if (char.IsLetter(symbol))
                letters++;
            if (char.IsPunctuation(symbol) && symbol != '.')
                punctuation++;
        }

        Console.WriteLine("\nРезультати:");
        Console.WriteLine($"Пробіли   :: {spaces}");
        Console.WriteLine($"Цифри     :: {digits}");
        Console.WriteLine($"Букви     :: {letters}");
        Console.WriteLine($"Знаки     :: {punctuation}");
    }

    static void task4()
    {
        Console.WriteLine("Вводьте символи. Для завершення введіть крапку ('.').");

        char symbol;

        Console.WriteLine("Перетворення малих літер у великі та навпаки:");

        do
        {
            symbol = (char)Console.Read();

            if (char.IsLower(symbol))
            {
                Console.Write(char.ToUpper(symbol));
                continue;
            }
            if (char.IsUpper(symbol))
            {
                Console.Write(char.ToLower(symbol));
                continue;
            }
            if (symbol != '\n' && symbol != '\r')
            {
                Console.Write(symbol);
                continue;
            }

        } while (symbol != '.');

        Console.WriteLine("\nПрограма завершена.");
    }

}