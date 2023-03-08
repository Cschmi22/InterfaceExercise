using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public Car()
        { 
        }
        public bool HasTrunk { get; set; } = true;
        public bool SedanBody { get; set; } = true;
        public string HasFourWheels { get; set; } = "Has 4 Wheels.";
        public string Model { get; set; } = "Chevy";
        public string Make { get; set; } = "Malibu";
        public int SeatCount { get; set; } = 4;
        public string Logo { get; set; } = "Plus Sign";
        public string CompanyName { get; set; } = "Chevrolet";
        public bool HasChangedGears { get; set; }
        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is driving forwards");
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is driving backwards");
                HasChangedGears= false;
            }
            else
            {
                Console.WriteLine("Can't reverse");
            }
        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is parked");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park");
            }
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears= isChanged;

        }





    }
}
