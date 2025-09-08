using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot carLot1 = new CarLot();
            Car car1 = new Car()
            {
                Year = 2015, EngineNoise = "VRRRRRRRMMMMMMMM", HonkNoise = "HOOOONNNNNNKKKKK", IsDriveable = true,
                Make = "Honda", Model = "Accord"
            };
            carLot1.AddCar(car1);
            Console.WriteLine(CarLot.numberOfCars);
            
            Car car2 = new Car()
            {
                Year = 2006, EngineNoise = "*Really Loud* VVVVVVRRRRRRRRRRRRRRMMMMMMMMMMMMM", HonkNoise = "beep",
                IsDriveable = false, Model = "Tuscan", Make = "Hyundai"
            };
            carLot1.AddCar(car2);
            Console.WriteLine(CarLot.numberOfCars);
            
            Car car3 = new Car()
            {
                Year = 2024, EngineNoise = "pppbbbttt", HonkNoise = "beep beep",  IsDriveable = true, Make = "Vespa", Model = "Primavera 50"
            };
            carLot1.AddCar(car3);
            Console.WriteLine(CarLot.numberOfCars);
            
            carLot1.ListCar();
            
            car1.MakeEngineNoise();
            car2.MakeEngineNoise();
            car3.MakeEngineNoise();
            car1.MakeHonkNoise();
            car2.MakeHonkNoise();
            car3.MakeHonkNoise();
        }
    }
}
