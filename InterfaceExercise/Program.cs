using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car()
            {
                HasTrunk = true,
                SedanBody = true,
                HasFourWheels = "Has 4 Wheels.",
                Model = "Malibu",
                Make = "Chevy",
                SeatCount = 4,

            };

            var truck = new Truck()
            {
                HasBed = true,
                CabSpace = "Extended",
                HasFourWheels = "Has 4 Wheels.",
                Model = "F-150",
                Make = "Ford",
                SeatCount = 4,

            };

            var suv = new SUV()
            {
                HasCargo = true,
                IsSporty = true,
                HasFourWheels = "Has 4 Wheels.",
                Model = "RAV-4",
                Make = "Toyota",
                SeatCount = 5,
            };
        var vehicles = new List<IVehicle>() { car, truck, suv};

        foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"The Make of this vehicle is {vehicle.Make}");
                Console.WriteLine($"The Model of this vehicle is {vehicle.Model}");
                Console.WriteLine($"This vehicle {vehicle.HasFourWheels}");
                Console.WriteLine($"This vehicle has a seat count of {vehicle.SeatCount}");
                Console.WriteLine();
                vehicle.Drive();
                vehicle.ChangeGears(true);
                vehicle.Reverse();
                Console.WriteLine();
                Console.WriteLine();
            }

    }
}
