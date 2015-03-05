using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Vehicle
    {
        private string vehicleType;

        public Vehicle(string vehicleType)
        {
            this.vehicleType = vehicleType;
        }

        public string Frame { get; set; }

        public string Engine { get; set; }

        public int Wheels { get; set; }

        public int Doors { get; set; }

        public void Show()
        {
            Console.WriteLine("Vehicle type: {0}", vehicleType);
            Console.WriteLine("Frame: {0}", Frame);
            Console.WriteLine("Engine: {0}", Engine);
            Console.WriteLine("Wheels: {0}", Wheels);
            Console.WriteLine("Doors: {0}", Doors);
        }
    }
}
