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
    class Car : IVehicle
    {
        public Car()
        {
            NumWheels = 4;
            EngineSize = "5.7L";
            VIN = Guid.NewGuid();
        }

        public int NumWheels { get; set; }
        public string EngineSize { get; set; }
        public Guid VIN { get; set; }

        public void Start()
        {
            Console.WriteLine(this.GetType().Name + " started up.");
        }


        //BUG: chance always resulting in the same value on normal execution
        //     different values in debug mode.

        //SOLUTION: default seed value derived from system clock results in same seed, producing identical sets of random numbers.
        //          resetting the seed should resolve this issue.
        public void CarFax()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            var chance = random.Next();

            if (chance % 2 == 0)
                Console.WriteLine("A car with the vin of " + VIN + " has been in an accident.");
            else
                Console.WriteLine("A car with the vin of " + VIN +  " is in good condition.");
        }
    }
}
