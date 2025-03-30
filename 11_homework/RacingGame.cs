using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _11_homework
{
    internal class RacingGame
    {
        private Car[] cars;
        private bool raceFinished = false;

        public RacingGame(Car[] cars)
        {
            this.cars = cars;
            foreach (Car car in cars)
            {
                car.OnFinish += CarFinished;
            }
        }

        private void CarFinished(string carName)
        {
            if (!raceFinished)
            {
                raceFinished = true;
                Console.WriteLine($"Переможець гонки: {carName}");
                ResetPositions();
            }
        }

        public void StartRace()
        {
            Console.WriteLine("Гонка починається!");
            Console.WriteLine();

            raceFinished = false;

            while (!raceFinished)
            {
                foreach (Car car in cars)
                {
                    if (raceFinished) 
                        break;
                    car.Move();
                    Console.WriteLine();
                }
            }
        }

        public void ResetPositions()
        {
            Console.WriteLine("\nСкидання позиций всих машин до 0...");
            foreach (Car car in cars)
            {
                car.Position = 0;
                Console.WriteLine($"\n{car.Name} повертається на стартову позицию (0)");
            }
        }
    }
}
