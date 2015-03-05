using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Builders
{
    public class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            this.Vehicle = new Vehicle("Scooter");
        }

        public override void BuildFrame()
        {
            this.Vehicle.Frame = "Scooter Frame";
        }

        public override void BuildEngine()
        {
            this.Vehicle.Engine = "50 cc";
        }

        public override void BuildWheels()
        {
            this.Vehicle.Wheels = 2;
        }

        public override void BuildDoors()
        {
            this.Vehicle.Doors = 0;
        }
    }
}
