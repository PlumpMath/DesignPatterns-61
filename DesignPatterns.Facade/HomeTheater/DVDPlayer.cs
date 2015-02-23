using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.HomeTheater
{
    public class DVDPlayer
    {
        public void On()
        {
            Console.WriteLine("DVD player is on");
        }

        public void Off()
        {
            Console.WriteLine("DVD player is off");
        }

        public void Play(string movieName)
        {
            Console.WriteLine("Watching '{0}'", movieName);
        }
    }
}
