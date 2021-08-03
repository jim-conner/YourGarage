using System;
using System.Collections.Generic;
using YourGarage.Cars;
using YourGarage.Vehicles.Cars;

namespace YourGarage.Vehicles
{
    abstract class VehicleBase
    {
        public int FuelCapacity { get; set; }
        public string Color { get; set; }
        public int PassengerOccupancy { get; set; }

        virtual public void Driving()
        {
            Console.WriteLine("Driving in VehicleBase.");
        }

        public void Refueling()
        {
            if (FuelCapacity < 50)
            {
                var formatCurrentFuelAmount = FuelCapacity.ToString("0.##\\%");
                Console.WriteLine($"Current Fuel Capacity: {formatCurrentFuelAmount}.  Time to fuel up!");
            }
        }
        static void Main(string[] args)
        {
            var wifesCar = new HondaCRV();
            var jimCar = new Prius();
            jimCar.hasBattery = true;
            var carList = new List<Car>() { wifesCar, jimCar };

            foreach (var car in carList)
            {
                car.Driving();
                car.Hybrid();
            }
        }

    }
}
