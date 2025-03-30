using System.IO;
using System.Text;


internal class Program
{
    static string currentDirectory = Directory.GetCurrentDirectory();

    static void CreateDirectory()
    {
        Console.Write("Введіть ім'я каталогу для створення :: ");
        string dirName = Console.ReadLine()!;
        string path = Path.Combine(currentDirectory,dirName);

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            Console.WriteLine("Каталог успішно додано!");
        }
        else
            Console.WriteLine("Каталог вже існує");
        Console.ReadLine();
    }

    static void DeleteDirectory()
    {
        Console.Write("Введіть ім'я каталогу для видалення ");
        string dirName = Console.ReadLine()!;
        string path = Path.Combine(currentDirectory, dirName);

        if (Directory.Exists(path))
        {
            Directory.Delete(path,true);
            Console.WriteLine("Каталог видалено!");
        }
        else
            Console.WriteLine("Каталог не існує");
        Console.ReadLine();
    }

    static void PrintDirectory()
    {
        Console.WriteLine("Вміст каталогу");
        string[] directories = Directory.GetDirectories(currentDirectory);
        string[] files = Directory.GetFiles(currentDirectory);

        Console.WriteLine();
        foreach (var dir in directories)
        {
            Console.WriteLine("  [D] " + Path.GetFileName(dir));
        }

        Console.WriteLine("\nФайли:");
        foreach (var file in files)
        {
            Console.WriteLine("  [F] " + Path.GetFileName(file));
        }
        Console.ReadLine();

    }

    static void DeleteFile()
    {
        Console.WriteLine("Ведіть ім'я файлу для видалення");
        string fileName = Console.ReadLine()!;
        string filePath = Path.Combine(currentDirectory, fileName);

        if (File.Exists(filePath))
        {
            File.Delete(filePath);
            Console.WriteLine("Файл видалено!");
        }
        else
            Console.WriteLine("Файл не існує");
        Console.ReadLine();
    }

    static void MoveFile()
    {
        Console.WriteLine("Введіть ім'я файлу для переміщення ");
        string fileName = Console.ReadLine()!;
        string sourcePath = Path.Combine(currentDirectory, fileName);

        if(!File.Exists(sourcePath))
        {
            Console.WriteLine("Файл не існує!");
            return;
        }

        Console.WriteLine("Введіть шлях до каталогу призначення ");
        string destDir = Console.ReadLine()!;

        if(!Directory.Exists(destDir))
        {
            Console.WriteLine("Каталог не існує ");
            return;
        }

        string destPath = Path.Combine(destDir,fileName);

        File.Move(sourcePath, destPath);
        Console.WriteLine("Файл успішно переміщено!");
        Console.ReadLine();

    }

    static void PrintFileInfo()
    {
        Console.WriteLine("Введіть ім'я файлу ");
        string fileName = Console.ReadLine()!;
        string filePath = Path.Combine(currentDirectory,fileName);

        if (File.Exists(filePath))
        {
            FileInfo fileInfo = new FileInfo(filePath);
            Console.WriteLine($"Ім'я          :: {fileInfo.Name}");
            Console.WriteLine($"Розмір        :: {fileInfo.Length} byte");
            Console.WriteLine($"Створений     :: {fileInfo.CreationTime}");
            Console.WriteLine($"Остання зміна :: {fileInfo.LastWriteTime}");
        }
        else
            Console.WriteLine("Файл не знайдено");
        Console.ReadLine();

    }

    static void ChangeDirectory()
    {
        Console.WriteLine();
        string newDir = Console.ReadLine()!;

        if(Directory.Exists(newDir))
        {
            currentDirectory = newDir;
            Console.WriteLine("Каталог зміщено!");
        }
        else
            Console.WriteLine("Каталог не існує");
        Console.ReadLine();

    }

    static void GoUp()
    {
        DirectoryInfo parentDir = Directory.GetParent(currentDirectory)!;

        if (parentDir != null)
        {
            currentDirectory = parentDir.FullName; 
            Console.WriteLine("Батьківський каталог тепер: " + parentDir.FullName);
        }
        else
            Console.WriteLine("Каталог не має батьківського.");
    }


    static void GoDown()
    {
        string[] directories = Directory.GetDirectories(currentDirectory);

        if (directories.Length == 0)
        {
            Console.WriteLine("Немає підкаталогів для спуску.");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("Доступні підкаталоги:");

        for (int i = 0; i < directories.Length; i++)
            Console.WriteLine($"{i + 1} - {Path.GetFileName(directories[i])}");

        Console.Write("Оберіть підкаталог для спуску (введіть номер): ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= directories.Length)
        {
            currentDirectory = directories[choice - 1];
            Console.WriteLine($"Перейшли в підкаталог: {currentDirectory}");
        }
        else
            Console.WriteLine("Невірний вибір.");

        Console.ReadLine();
    }


    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        while(true)
        {
            Console.Clear();
            Console.WriteLine($"Поточний каталог :: {currentDirectory}");
            Console.WriteLine("[1] - Створити каталог");
            Console.WriteLine("[2] - Видалити каталог");
            Console.WriteLine("[3] - Переглянути вміст каталог");
            Console.WriteLine("[4] - Видалити файл");
            Console.WriteLine("[5] - Перемістити файл");
            Console.WriteLine("[6] - Переглянути інформацію про файл");
            Console.WriteLine("[7] - Змінити поточний каталог");
            Console.WriteLine("[8] - Спуститися в дереві");
            Console.WriteLine("[9] - Піднятися в дереві");
            Console.WriteLine("[0] - Вийти");
            Console.Write("\n\tОбреріть опцію :: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CreateDirectory(); break;
                case "2":
                    DeleteDirectory(); break;
                case "3":
                    PrintDirectory(); break;
                case "4":
                    DeleteFile(); break;
                case "5":
                    MoveFile(); break;
                case "6":
                    PrintFileInfo(); break;
                case "7":
                    ChangeDirectory(); break;
                case "8":
                    GoDown(); break;
                case "9":
                    GoUp(); break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Невірний вибір! Натисніть Enter для продовження");
                    Console.ReadLine();
                    break;

            }
        }
    }
}