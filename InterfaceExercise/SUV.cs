using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV() {}
        public bool HasCargo { get; set; } = true;
        public bool IsSporty { get; set; } = true;
        public string HasFourWheels { get; set; } = "Has 4 Wheels.";
        public string Model { get; set; } = "Toyota";
        public string Make { get; set; } = "RAV4";
        public int SeatCount { get; set; } = 5;
        public string Logo { get; set; } = "*Insert Toyota Logo*";
        public string CompanyName { get; set; } = "Toyota";
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
