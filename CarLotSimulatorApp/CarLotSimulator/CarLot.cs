using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    private List<Car> _cars =  new List<Car>();
    public static int numberOfCars;

    public void AddCar(Car car)
    {
        _cars.Add(car);
    }

    public void ListCar()
    {
        foreach (Car car in _cars)
        {
            Console.WriteLine(car.Make);
            Console.WriteLine(car.Model);
            Console.WriteLine(car.Year);
        }
    }
}