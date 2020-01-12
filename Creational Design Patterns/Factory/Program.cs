using Factory.Concrete_Creators;
using Factory.Concrete_Products;
using System;

namespace Factory
{
    /// <summary>
    /// The factory method defines an interface for creating an object, but does not define what objects the individual implementation of
    /// the interface must instantiate. 
    /// 
    /// This pattern excels at creating groups of related objects. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var fordDealer = new FordDealership();
            var toyotaDealer = new ToyotaDealership();

            fordDealer.PrintVehicles();
            
            foreach (IVehicle vehicle in fordDealer.Vehicles)
            {
                vehicle.Start();
                if (vehicle.GetType() == typeof(Car)) //vehicle is Car also acceptable
                {
                    Car car = (Car)vehicle;
                    car.CarFax();

                }
            }

            Console.ReadKey();

        }
    }
}
