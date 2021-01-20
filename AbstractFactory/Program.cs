using AbstractFactory.Factory;
using AbstractFactory.Models.Car;
using AbstractFactory.Models.Motorcycle;
using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory<Car> carFactory = new CarFactory();
            VehicleFactory<Motorcycle> mcFactory = new MotorcycleFactory();

            var cars = new List<Car>
            {
                carFactory.GetVehicle(nameof(Mazda)),
                carFactory.GetVehicle(nameof(Passat)),
                carFactory.GetVehicle(nameof(Toledo))
            };

            var motocycles = new List<Motorcycle> 
            { 
                mcFactory.GetVehicle(nameof(Yamaha)),
                mcFactory.GetVehicle(nameof(Honda)),
                mcFactory.GetVehicle(nameof(Ducati))
            };

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Name} has {car.HorsePowers} HP.");
            }

            foreach (var mc in motocycles)
            {
                Console.WriteLine($"{mc.Name} has {mc.HorsePowers} HP.");
            }
        }
    }
}
