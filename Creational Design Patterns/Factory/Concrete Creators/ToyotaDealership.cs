﻿using Factory.Concrete_Products;
using System;

namespace Factory.Concrete_Creators
{
    class ToyotaDealership : Dealership
    {
        public override void PrintVehicles()
        {
            throw new NotImplementedException();
        }

        public override void StockVehicles()
        {
            Vehicles.Add(new Motorcycle());
            Vehicles.Add(new Car());
            Vehicles.Add(new Truck());
            Vehicles.Add(new Car());
            Vehicles.Add(new Truck());
            Vehicles.Add(new Truck());
        }
    }
}
