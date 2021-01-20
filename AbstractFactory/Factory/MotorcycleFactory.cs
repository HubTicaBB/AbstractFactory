using AbstractFactory.Models.Motorcycle;

namespace AbstractFactory.Factory
{
    public class MotorcycleFactory : VehicleFactory<Motorcycle>
    {
        protected override Motorcycle CreateVehicle(string name) => name switch
        {
            nameof(Yamaha) => new Yamaha(),
            nameof(Honda) => new Honda(),
            nameof(Ducati) => new Ducati(),
            _ => null
        };
    }
}
