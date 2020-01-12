using System.Collections.Generic;

namespace Factory.Concrete_Creators
{
    /// <summary>
    /// The creator declares a factory method, which returns an object of the product type.
    /// Can also define a default implementation of the factory method.
    /// </summary>
    abstract class Dealership
    {
        public Dealership()
        {
            Vehicles = new List<IVehicle>();
            StockVehicles();
        }

        public abstract void StockVehicles();

        public List<IVehicle> Vehicles { get; }

        public abstract void PrintVehicles();
    }
}
