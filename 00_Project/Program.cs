using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

class Game
{
    static int kill_;
    static int hp_;
    static int stamina_;
    static int money_;
    static int resurs_;

    static Hero? player;
    static List<Enemy>? enemies;
    static List<Enemy>? BigBoss;
    static List<Resource>? resources;
    static List<Resource>? backpack;

    public static event Action? OnLowStamina;

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Ласкаво просимо в гру на виживання!");

        player = new Hero("Герой",3, 8, 5, 10);
        Console.Write($"\nВведіть ім'я персонажу :: ");
        player.Name = Console.ReadLine()!;
        InitializeGame();

        OnLowStamina += NotifyLowStamina;

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Характеристики : {player.Name}, Здоров'я {player.Hp}, Сила: {player.Strength}, Витривалість: {player.Stamina}, Золото: {player.Gold}");
            Console.WriteLine("\nОберіть дію:");
            Console.WriteLine("1. Досліджувати локацію");
            Console.WriteLine("2. Видобувати ресурси");
            Console.WriteLine("3. Битися з ворогами");
            Console.WriteLine("4. Відпочити");
            Console.WriteLine("5. Переглянути рюкзак");
            Console.WriteLine("6. Зайти в магазин");
            Console.WriteLine("7. Битва з босом");
            Console.WriteLine("0. Вийти з гри");
            Console.Write("\nВиберать дію :: ");

            string choice = Console.ReadLine()!;
            switch (choice)
            {
                case "1":
                    if (!Fatigue())
                        break;
                    Explore();
                    break;
                case "2":
                    if (!Fatigue())
                        break;
                    GatherResources();
                    break;
                case "3":
                    if (!Fatigue())
                        break;
                    if(!FightEnemy())
                        return;
                    break;
                case "4":
                    Rest();
                    break;
                case "5":
                    ViewBackpack();
                    break;
                case "6":
                    Shop();
                    break;
                case "7":
                    if (!Fatigue())
                        break;
                    if (!BossFight())
                        return;
                    break;
                case "0":
                    Console.WriteLine("\nДякуємо за гру!");
                    return;
                default:
                    Console.WriteLine("Невірний вибір!");
                    break;
            }

            Console.Write("\nНатисніть Enter для продовження...");
            Console.ReadLine();
        }
    }

    static void Shop()
    {
        int tmp = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Характеристики: {player?.Name}, Здоров'я {player?.Hp}, Сила: {player?.Strength}, Витривалість: {player?.Stamina}, Золото: {player?.Gold}");
            ViewBackpack();
            Console.WriteLine("\nЛаскаво просимо в \"Магазин для мандрівників\"!");
            Console.WriteLine("Товари:\n1. Ніж (+3 сили) - 5 золота  та 3 дерева\n2. Меч (+5 сили) - 10 золота та 5 дерева\n3. Лук (+7 сили) - 15 золота та 3 заліза\n4. Довгий меч (+9 сили) - 20 золота та 3 діаманта\n5. Лікі (+2 здоров'я) - 10 золота");
            Console.Write("Ведіть позицію товару або [0] - щоб вийти: ");
            string choice = Console.ReadLine()!;
            Console.WriteLine();
            switch (choice)
            {
                case "1":
                    if (player?.Gold >= 5 && backpack![2].Quantity >= 3)
                    {
                        tmp += 1;
                        player.Gold -= 5;
                        backpack![2].Quantity -= 3;
                        player.Strength += 3;
                        Console.WriteLine("Гравец купив Ніж його сила збільшилась на 3 - Він заплатив 5 золота та 3 дерева");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("Вам не хватає золота або дерева щоб купити - Ніж");
                        Console.ReadLine();
                        break;
                    }
                    break;
                case "2":
                    if (player?.Gold >= 10 && backpack![2].Quantity >= 5)
                    {
                        tmp += 1;
                        player.Gold -= 10;
                        backpack![2].Quantity -= 5;
                        player.Strength += 5;
                        Console.WriteLine("Гравец купив Меч його сила збільшилась на 5 - Він заплатив 10 золота та 5 дерева");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("Вам не хватає золота або дерева щоб купити - Меч");
                        Console.ReadLine();
                        break;
                    }
                    break;
                case "3":
                    if (player?.Gold >= 15 && backpack![1].Quantity >= 3)
                    {
                        tmp += 1;
                        player.Gold -= 15;
                        backpack![1].Quantity -= 3;
                        player.Strength += 7;
                        Console.WriteLine("Гравец купив Лук його сила збільшилась на 7 - Він заплатив 15 золота та 3 заліза"); 
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("Вам не хватає золота або заліза щоб купити - Лук"); 
                        Console.ReadLine();
                        break;
                    }
                    break;
                case "4":
                    if (player?.Gold >= 20 && backpack![0].Quantity >= 3)
                    {
                        tmp += 1;
                        player.Gold -= 20;
                        backpack![0].Quantity -= 3;
                        player.Strength += 9;
                        Console.WriteLine("Гравец купив Довгий меч його сила збільшилась на 9 - Він заплатив 20 золота та 3 діаманта");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("Вам не хватає золота або діамантів щоб купити - Довгий меч");
                        Console.ReadLine();
                        break;
                    }
                    break;
                case "5":
                    if (player?.Gold >= 10)
                    {
                        tmp += 1;
                        player.Gold -= 10;
                        player.Hp += 2;
                        Console.WriteLine("Гравец купи Лікі його здоров'я збільшилось на 2 - Він заплатив 10 золота");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("Вам не хватає золота щоб купити - Лікі");
                        Console.ReadLine();
                        break;
                    }
                    break;
                case "0":
                    if (tmp > 0)
                    {
                        Console.WriteLine("Дякую за покупки заходьте ще");
                        tmp = 0;
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Нажаль гравец нічого не купив");
                        return;
                    }
                default:
                    Console.WriteLine("Невірний вибір!");
                    break;
            }
        }
    }

    static bool Fatigue()
    {
        if (player?.Stamina <= 0)
        {
            Console.WriteLine($"\nУ {player.Name} Немає витривалості тому він неможе нічого робить відпочиньте щоб відновити витривалість!");
            return false;
        }
        else
            return true;
    }

    static void InitializeGame()
    {
        kill_ = 0;
        hp_ = 0;
        stamina_ = 0;
        money_ = 0;
        resurs_ = 0;

        BigBoss = new List<Enemy>
        {
            new Enemy("Молодий Дракон", 15, 14),
            new Enemy("Дракон", 20, 18),
            new Enemy("Старий Дракон", 30, 25)
        };

        enemies = new List<Enemy>
        {
            new Enemy("Монстр", 9, 5),
            new Enemy("Монстр", 8, 4),
            new Enemy("Монстр", 7, 3),
            new Enemy("Тварина", 10, 5),
            new Enemy("Тварина", 8, 4),
            new Enemy("Тварина", 6, 3)
        };

        resources = new List<Resource>
        {
            new Resource("Діаманти", 2),
            new Resource("Діаманти", 1),
            new Resource("Діаманти", 3),
            new Resource("Залізо", 5),
            new Resource("Залізо", 2),
            new Resource("Залізо", 3),
            new Resource("Дерево", 5),
            new Resource("Дерево", 1),
            new Resource("Дерево", 3),
        };

        backpack = new List<Resource>
        {
            new Resource("Діаманти", 0),
            new Resource("Залізо", 0),
            new Resource("Дерево", 0)
        };
    }

    static void Explore()
    {
        Console.WriteLine("\nГерой досліджує локацію...");
        Random rand = new Random();
        int eventChance = rand.Next(1, 4);

        if (eventChance == 1)
        {
            Console.WriteLine("Ви знайшли ворога!");
            FightEnemy();
        }
        else if (eventChance == 2)
        {
            Console.WriteLine("Ви знайшли ресурси!");
            GatherResources();
        }
        else
        {
            Console.WriteLine("Нічого цікавого не сталося...");
            Console.WriteLine("Ви марно витратили : 1 витривалість");
            player!.Stamina -= 1;
            CheckStamina();
        }
    }

    static void GatherResources()
    {
        Console.WriteLine();
        Random rand = new Random();
        Resource resource = resources![rand.Next(resources.Count)];
        Console.WriteLine($"Ви знайшли {resource.Name} (кількість: {resource.Quantity})!");
        player!.CollectResource(resource);
        if(resource.Name == "Діаманти")
        {
            if (player!.Stamina < 3)
            {
                Console.WriteLine($"Вам нехватає витривалості для добутя {resource.Name}");
                return;
            }
            Console.WriteLine($"Гравец витратив на добування {resource.Name} : 3 витривалість");
            backpack![0].Quantity += resource.Quantity;
            player.Stamina -= 3;
            stamina_ += 3;
            resurs_ += resource.Quantity;
        }
        else if (resource.Name == "Залізо")
        {
            if (player!.Stamina < 2)
            { 
                Console.WriteLine($"Вам нехватає витривалості для добутя {resource.Name}");
                return;
            }
            Console.WriteLine($"Гравец витратив на добування {resource.Name} : 2 витривалість");
            backpack![1].Quantity += resource.Quantity;
            player.Stamina -= 2;
            stamina_ += 2;
            resurs_ += resource.Quantity;
        }
        else if (resource.Name == "Дерево")
        {
            Console.WriteLine($"Гравец витратив на добування {resource.Name} : 1 витривалість");
            backpack![2].Quantity += resource.Quantity;
            player.Stamina -= 1;
            stamina_++;
            resurs_ += resource.Quantity;
        }
        CheckStamina();
    }

    static bool FightEnemy()
    {
        Console.WriteLine();
        Random rand = new Random();
        Enemy enemy = enemies![rand.Next(enemies.Count)];
        Console.WriteLine($"Ви зустріли {enemy.Name} (Сила: {enemy.Strength})!");

        if (player!.Strength >= enemy.Strength)
        {
            Console.WriteLine("Ви перемогли ворога!");
            player.Gold += enemy.Reward;
            Console.WriteLine($"Гравец переміг {enemy.Name} і витратив : 1 витривалість");
            player.Stamina -= 1;
            money_ += enemy.Reward;
            stamina_++;
            kill_++;
            CheckStamina();
            return true;
        }
        else
        {
            Console.WriteLine("Ви програли битву і втратили :: 1 - здоров'я та 1 - витривалість");
            player.Hp -= 1;
            hp_++;
            stamina_++;
            player.Stamina -= 1;
            if(player.Hp <= 0)
            {
                Console.WriteLine("\nВи вмерли");
                return false;
            }
            CheckStamina();
            return true;
        }
    }

    static void Rest()
    {
        Console.WriteLine("\nГерой відпочиває та відновлює сили...");
        player!.Stamina += 2;
    }

    static void ViewBackpack()
    {
        Console.WriteLine("\nУ гравця в рюкзаку є ");
        Console.WriteLine($"{backpack![0].Name} в кількості :: {backpack[0].Quantity}");
        Console.WriteLine($"{backpack[1].Name} в кількості   :: {backpack[1].Quantity}");
        Console.WriteLine($"{backpack[2].Name} в кількості   :: {backpack[2].Quantity}");
    }

    static void CheckStamina()
    {
        if (player!.Stamina <= 0)
        {
            OnLowStamina?.Invoke();
        }
    }

    static void NotifyLowStamina()
    {
        Console.WriteLine("\nУ вашого героя закінчилась витривалість! Вам потрібно відпочити.");
    }

    static bool BossFight()
    {
        Enemy boss = BigBoss!.First();
        int tmp = BigBoss!.Capacity;
        Console.WriteLine($"\nВи прийли в логово босса \nГоловний ворог даної локації {boss?.Name}!!! \n\nХарактеристикі босса: Ім'я {boss?.Name} Сила {boss?.Strength} Винагорода {boss?.Reward} золота");
        Console.WriteLine($"Характеристикі Героя: Ім'я {player?.Name} Здоров'я {player?.Hp} Сила {player?.Strength}\n");

        if (player!.Strength >= boss!.Strength)
        {
            Console.WriteLine($"Ви перемогли Босса [{tmp - BigBoss.Count}] локації і витратив : 1 витривалість \nЗа перемогу ви отримали {boss?.Reward} золота");
            BigBoss.RemoveAt(0);
            player.Gold += boss!.Reward;
            player.Stamina -= 1;
            stamina_++;
            kill_++;
            CheckStamina();
            if (BigBoss?.Count == 0)
            {
                Console.WriteLine("Ви перемогли останнього босса \n");
                Console.Write("\nНатисніть Enter для виведення фінальної статистики ");
                Console.ReadLine();
                Console.Clear();
                Final();
                Console.WriteLine("\nДякую за те, що грали!");
                return false;
            }
            else
                Console.WriteLine($"Вам потрібно вбити ще {BigBoss?.Count} Босса щоб пройти гру.");
            return true;
        }
        else
        {
            Console.WriteLine($"Ви програли битву з Боссом [{(tmp - (BigBoss!.Count)) + 1}] локації і втратили :: 1 - здоров'я та 1 - витривалість");
            player!.Hp -= 1;
            hp_++;
            stamina_++;
            player.Stamina -= 1;
            if (player.Hp <= 0)
            {
                Console.WriteLine($"\nВи вмерли в битві з Боссом [{(tmp - (BigBoss!.Count)) + 1}] локації");
                return false;
            }
            Console.WriteLine("Нажаль вам не вистачило сил для перемогі над Боссом \nНакопіть монет та купіть снаряддя в магазині щоб збільшити свою силу");
            CheckStamina();
            return true;
        }
    }

    static void Final()
    {
        Console.WriteLine("Фінальна статистика\n");
        Console.WriteLine($"Характеристики : {player!.Name}, Здоров'я {player.Hp}, Сила: {player.Strength}, Витривалість: {player.Stamina}, Золото: {player.Gold} \n");
        Console.WriteLine($"Сумарна кількість витраченої витривалості :: {stamina_}");
        Console.WriteLine($"Сумарна кількість втраченого здоров'я     :: {hp_}");
        Console.WriteLine($"Сумарна кількість витраченого золота      :: {money_}");
        Console.WriteLine($"Сумарна кількість добутих ресурсів        :: {resurs_}");
        Console.WriteLine($"Сумарна кількість вбитих ворогів          :: {kill_}");
    }

    class Hero
    {
        private string name;

        private int hp;

        public int Hp
        {
            get => hp;
            set
            {
                if (value > 0)
                {
                    hp = value;
                }
                else
                {
                    hp = 0;
                }
            }
        }

        public string Name
        {
            get => name;
            set
            {
                if (value.Length >= 5)
                    name = value;
                else
                    name = "Герой";
            }
        }

        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Gold { get; set; }

        public Hero(string name,int hp, int strength, int stamina, int gold)
        {
            Name = name;
            Hp = hp;
            Strength = strength;
            Stamina = stamina;
            Gold = gold;
        }

        public void CollectResource(Resource resource)
        {
            Console.WriteLine($"Герой зібрав {resource.Quantity} одиниць {resource.Name}.");
            Gold += resource.Quantity;
        }
    }

    class Enemy
    {
        public string Name { get; }
        public int Strength { get; }
        public int Reward { get; }

        public Enemy(string name, int strength, int reward = 10)
        {
            Name = name;
            Strength = strength;
            Reward = reward;
        }
    }

    class Resource
    {
        private string name;

        private int quantity;
        public string Name 
        { 
            get => name;
            set
            {
                if (value.Length > 1)
                    name = value;
                else
                    name = "NoName";
            }
        }
        public int Quantity 
        { 
            get => quantity; 
            set
            {
                if (value > 0)
                    quantity = value;
                else
                    quantity = 0;
            }
        }

        public Resource(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
    }

}