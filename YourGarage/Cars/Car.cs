using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage.Vehicles
{
    class Car : VehicleBase
    {
        public int ModelYear { get; set; }
        public bool isHybrid { get; set; }

        public override void Driving()
        {
            Console.WriteLine("The car is crusin' down the road.");
        }

        public bool Hybrid()
        {
            Console.WriteLine(
                $"The {Color} car is {(isHybrid ? "a hybrid" : "killing the enviornment")} "
                );
            return isHybrid;
        }



    }
}
