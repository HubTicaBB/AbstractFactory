namespace AbstractFactory
{
    public class CarFactory : VehicleFactory<Car>
    {
        protected override Car CreateVehicle(string name)
        {
            return name switch
            {
                nameof(Mazda) => new Mazda();
                nameof(Passat) => new Passat();
                nameof(Toledo) => new Toledo();
            }
        }
    }
}