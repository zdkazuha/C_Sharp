using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Product
{
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public DateTime ManufactureDate { get; set; }
    public string? Country { get; set; }
    public Category? Category { get; set; }
}

public class Category
{
    public string? Name { get; set; }
}

internal class Program
{
    private static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        var categories = new List<Category>
        {
            new Category { Name = "Електроніка" },
            new Category { Name = "Одяг" },
            new Category { Name = "Продукти" }
        };

        var products = new List<Product>
        {
            new Product { Name = "Телевізор", Price = 5000, ManufactureDate = new DateTime(2024, 1, 1), Country = "Україна", Category = categories[0] },
            new Product { Name = "Ноутбук", Price = 15000, ManufactureDate = new DateTime(2025, 2, 1), Country = "Китай", Category = categories[0] },
            new Product { Name = "Футболка", Price = 200, ManufactureDate = new DateTime(2023, 5, 1), Country = "Україна", Category = categories[1] },
            new Product { Name = "Хліб", Price = 25, ManufactureDate = new DateTime(2025, 1, 1), Country = "Україна", Category = categories[2] },
            new Product { Name = "Молоко", Price = 30, ManufactureDate = new DateTime(2025, 1, 10), Country = "Білорусь", Category = categories[2] },
            new Product { Name = "Штани", Price = 800, ManufactureDate = new DateTime(2024, 9, 15), Country = "Італія", Category = categories[1] }
        };

        var currentYear = DateTime.Now.Year;
        string selectedCountry = "Україна";
        string selectedCategoryName = "Електроніка";
        var productsInCurrentYear = products
            .Where(p => p.ManufactureDate.Year == currentYear)
            .OrderByDescending(p => p.Price)
            .ToList();

        Console.WriteLine("Завдання 1:");
        foreach (var product in productsInCurrentYear)
        {
            Console.WriteLine($"{product.Name} - {product.Price} грн");
        }

        // 2
        var productCountInCountry = products
            .Count(p => p.Country == selectedCountry);

        Console.WriteLine($"\nЗавдання 2: Кількість продуктів в {selectedCountry}: {productCountInCountry}");

        // 3
        var selectedCategory = categories.FirstOrDefault(c => c.Name == selectedCategoryName);

        var cheapestProduct = products
            .Where(p => p.Category == selectedCategory)
            .OrderBy(p => p.Price)
            .FirstOrDefault();

        var mostExpensiveProduct = products
            .Where(p => p.Category == selectedCategory)
            .OrderByDescending(p => p.Price)
            .FirstOrDefault();

        Console.WriteLine($"\nЗавдання 3: Найдешевший та найдорожчий продукт у категорії {selectedCategoryName}:");
        Console.WriteLine($"Найдешевший: {cheapestProduct!.Name} - {cheapestProduct.Price} грн");
        Console.WriteLine($"Найдорожчий: {mostExpensiveProduct!.Name} - {mostExpensiveProduct.Price} грн");

        // 4
        var categoriesNotInUkraine = products
            .Where(p => p.Country != "Україна")
            .Select(p => p.Category?.Name)
            .Distinct()
            .ToList();

        Console.WriteLine("\nЗавдання 4: Категорії, продукти яких не виготовляються в Україні:");
        foreach (var categoryName in categoriesNotInUkraine)
        {
            Console.WriteLine(categoryName);
        }

        // 5
        var productCountByCategory = products
            .GroupBy(p => p.Category)
            .Select(group => new
            {
                CategoryName = group?.Key?.Name,
                ProductCount = group?.Count()
            })
            .ToList();

        Console.WriteLine("\nЗавдання 5: Кількість продуктів в кожній категорії:");
        foreach (var categoryCount in productCountByCategory)
        {
            Console.WriteLine($"{categoryCount.CategoryName}: {categoryCount.ProductCount}");
        }

        // 6
        var groupedByCategory = products
            .GroupBy(p => p.Category)
            .Select(group => new
            {
                CategoryName = group?.Key?.Name,
                Products = group?.OrderBy(p => p.ManufactureDate).ToList()
            })
            .ToList();

        Console.WriteLine("\nЗавдання 6: Продукти, згруповані по категоріях і відсортовані по даті виготовлення:");
        foreach (var categoryGroup in groupedByCategory)
        {
            Console.WriteLine($"\nКатегорія: {categoryGroup.CategoryName}");
            foreach (var product in categoryGroup.Products!)
            {
                Console.WriteLine($"{product.Name} - {product.ManufactureDate.ToShortDateString()}");
            }
        }
    }
}
