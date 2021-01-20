namespace AbstractFactory.Factory
{
    public abstract class VehicleFactory<T>
    {
        public T GetVehicle(string name) => CreateVehicle(name);

        protected abstract T CreateVehicle(string name);
    }
}
