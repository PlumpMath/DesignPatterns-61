using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.HomeTheater
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector is on");
        }

        public void Off()
        {
            Console.WriteLine("Projector is off");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Wide screen mode");
        }

        public void TVMode()
        {
            Console.WriteLine("TV mode");
        }
    }
}
