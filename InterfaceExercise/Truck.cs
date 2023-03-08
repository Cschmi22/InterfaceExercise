using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck() { }
        public bool HasBed { get; set; } = true;
        public string CabSpace { get; set; } = "Extended";
        public string HasFourWheels { get; set; } = "Has 4 Wheels.";
        public string Model { get; set; } = "Ford";
        public string Make { get; set; } = "F-150";
        public int SeatCount { get; set; } = 2;
        public string Logo { get; set; } = "Ford";
        public string CompanyName { get; set; } = "Ford";
        public bool HasChangedGears { get; set; }
        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is driving forward");
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is driving backwards");
                HasChangedGears = false;
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
                Console.WriteLine($"{GetType().Name} is not");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park");
            }
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;

        }
    }
}
