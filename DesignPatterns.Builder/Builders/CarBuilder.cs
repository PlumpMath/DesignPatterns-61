using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Builders
{
    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            this.Vehicle = new Vehicle("Car");
        }

        public override void BuildFrame()
        {
            this.Vehicle.Frame = "Car Frame";
        }

        public override void BuildEngine()
        {
            this.Vehicle.Engine = "2500 cc";
        }

        public override void BuildWheels()
        {
            this.Vehicle.Wheels = 4;
        }

        public override void BuildDoors()
        {
            this.Vehicle.Doors = 4;
        }
    }
}
