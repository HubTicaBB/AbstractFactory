using AbstractFactory.Models.Car;

namespace AbstractFactory.Factory
{
    public class CarFactory : VehicleFactory<Car>
    {
        protected override Car CreateVehicle(string name) => name switch 
        { 
            nameof(Mazda) => new Mazda(),
            nameof(Passat) => new Passat(),
            nameof(Toledo) => new Toledo(),
            _ => null
        };
    }
}
