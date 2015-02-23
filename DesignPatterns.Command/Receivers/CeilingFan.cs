using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Receivers
{
    public class CeilingFan
    {
        public enum Speed
        {
            Off = 0,
            Low = 1,
            Medium = 2,
            High = 3
        }

        private Speed speed;

        public CeilingFan()
        {
            this.speed = Speed.Off;
        }

        public Speed CurrentSpeed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
                Console.WriteLine("Ceiling fan speed is {0}", speed.ToString());
            }
        }
    }
}
