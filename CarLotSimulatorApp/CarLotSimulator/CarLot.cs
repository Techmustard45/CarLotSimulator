using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    private List<Car> Cars =  new List<Car>();
    public static int numberOfCars;

    public void addCar(Car car)
    {
        Cars.Add(car);
    }

    public void nameCar()
    {
        foreach (Car car in Cars)
        {
            Console.WriteLine(car.Make);
            Console.WriteLine(car.Model);
            Console.WriteLine(car.Year);
        }
    }
}