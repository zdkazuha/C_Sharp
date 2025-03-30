using _15_Serializers;
using Newtonsoft.Json;
using System.Text.Json;
using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car(111, "Toyota", 2.3);
        Car car2 = new Car(222, "Ford", 2.6);
        string fname = "../../../car.json";

        string json = System.Text.Json.JsonSerializer.Serialize<Car>(car); // only property
        Console.WriteLine(json);
        File.WriteAllText(fname, json);

        Car res = System.Text.Json.JsonSerializer.Deserialize<Car>(File.ReadAllText(fname))!;

        Console.WriteLine(car);
        Console.WriteLine(res);

        /*string*/ json = JsonConvert.SerializeObject(car);
        File.WriteAllText(fname, json);
        Console.WriteLine(JsonConvert.DeserializeObject<Car>(File.ReadAllText(fname)));


        string fname2 = "../../../salon.json";
        List<Car> salonList = new List<Car>()
        {
            car,
            car2,
            new Car(333,"BMW",2.9)
        };

        File.WriteAllText(fname2, JsonConvert.SerializeObject(salonList));
        Console.WriteLine(String.Join<Car>("\n", JsonConvert.DeserializeObject<List<Car>>(File.ReadAllText(fname2))!));

        /*string*/ json = System.Text.Json.JsonSerializer.Serialize<List<Car>>(salonList); // only property
        Console.WriteLine(json);
        File.WriteAllText(fname2, json);

        List<Car> res2 = System.Text.Json.JsonSerializer.Deserialize<List<Car>>(File.ReadAllText(fname2))!;
        Console.WriteLine(String.Join<Car>("\n", res2));

        Dictionary<int, Car> salonList2 = new Dictionary<int, Car>()
        {
            [car.id] = car,
            [car2.id] = car2,
            [333] = new Car(333, "BMW", 2.9)
        };


        /*string*/ json = System.Text.Json.JsonSerializer.Serialize<Dictionary<int, Car>>(salonList2); // only property
        Console.WriteLine(json);
        File.WriteAllText(fname2, json);

        Dictionary<int, Car> res3 = System.Text.Json.JsonSerializer.Deserialize<Dictionary<int, Car>>(File.ReadAllText(fname2))!;
        foreach (var item in res3)
        {
            item.Value.id = item.Key;
            Console.WriteLine($"{item.Value}");
        }

        File.WriteAllText(fname2, JsonConvert.SerializeObject(salonList));
        foreach (var item in JsonConvert.DeserializeObject<Dictionary<int, Car>>(File.ReadAllText(fname2))!)
        {
            Console.WriteLine(item.Value);
        }


    }
}