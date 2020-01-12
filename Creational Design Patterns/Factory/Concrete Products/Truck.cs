using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Concrete_Products
{
    /// <summary>
    /// The concrete implementation of the abstract class or interface. Derives the methods of the abstract class/interface, and may have 
    /// properties or methods of its own.
    /// </summary>
    class Truck : IVehicle
    {
        public void Start()
        {
            Console.WriteLine(this.GetType().Name + " started up.");
        }
    }
}
