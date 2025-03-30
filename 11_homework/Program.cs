using _11_homework;

internal class Program
{
    private static void Main(string[] args)
    {
        Car[] cars = new Car[]
        {
            new SportCar("Ferrari"),
            new Truck("Volvo")
        };

        RacingGame race = new RacingGame(cars);

        race.StartRace(); 
        race.StartRace(); 
    }
}
