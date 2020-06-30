using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();
           

            var kathyasCar = new Car();

            kathyasCar.Make = "Ford";
            kathyasCar.Model = "Mustang";
            kathyasCar.Year = 2019;
            kathyasCar.EngineNoise = "vroom vroom";
            kathyasCar.HonkNoise = "tweet";
            kathyasCar.IsDrivable = true;

            lot.Cars.Add(kathyasCar);

            var breannasCar = new Car()
            {
                Year = 2020,
                Make = "Lexus",
                Model = "GS",
                EngineNoise = "quiet",
                HonkNoise = "loud",
                IsDrivable = true

            };

            lot.Cars.Add(breannasCar);

            var lunasCar = new Car();
            lunasCar.Make = "Ford";
            lunasCar.Model = "FX";
            lunasCar.Year = 2018;
            lunasCar.EngineNoise = "woof";
            lunasCar.HonkNoise = "poing";
            lunasCar.IsDrivable = true;

            lot.Cars.Add(lunasCar);


            var mommysCar = new Car(2019, "Toyota", "Forrunner", "vreoom", "beep beep", true);

            lot.Cars.Add(mommysCar);


            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }



        }
    }
}
