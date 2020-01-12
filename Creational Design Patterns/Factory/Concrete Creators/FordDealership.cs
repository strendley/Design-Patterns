using Factory.Concrete_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Concrete_Creators
{
    /// <summary>
    /// The concrete creator overrides the factory method to return an instance of a concrete product.
    /// </summary>
    class FordDealership : Dealership
    {
        public override void PrintVehicles()
        {

            Console.WriteLine("Welcome to the " + this.GetType().Name + "!");
            int carCount = 0;
            int bikeCount = 0;
            int truckCount = 0;
            foreach (IVehicle vehicle in Vehicles)
            {
                if (vehicle is Car)
                    carCount++;
                else if (vehicle is Truck)
                    truckCount++;
                else if (vehicle is Motorcycle)
                    bikeCount++;
                else
                    Console.WriteLine("Unknown Vehicle Type");

            }

            Console.WriteLine("Today, we have " + carCount + " " + typeof(Car).Name + "(s) " + truckCount + " " + typeof(Truck).Name + "(s), and " + bikeCount + " " + typeof(Motorcycle).Name + "(s) available for purchase.");
        }

        public override void StockVehicles()
        {
            Vehicles.Add(new Truck());
            Vehicles.Add(new Truck());
            Vehicles.Add(new Truck());
            Vehicles.Add(new Motorcycle());
            Vehicles.Add(new Car());
            Vehicles.Add(new Truck());
            Vehicles.Add(new Car());
        }
    }
}
