namespace AbstractFactory
{
    public abstract class VehicleFactory<T>
    {
        public T GetCar(string name)
        {
            return CreateCar(name);
        }

        protected abstract T CreateCar(string name);
    }
}