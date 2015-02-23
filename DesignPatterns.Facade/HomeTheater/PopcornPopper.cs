using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.HomeTheater
{
    public class PopcornPopper
    {
        public void On()
        {
            Console.WriteLine("Popcorn popper is on");
        }

        public void Off()
        {
            Console.WriteLine("Popcorn popper is off");
        }

        public void Pop()
        {
            Console.WriteLine("Popping popcorn");
        }
    }
}
