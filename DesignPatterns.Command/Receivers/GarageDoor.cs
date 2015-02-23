using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Receivers
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage door is open");
        }

        public void Down()
        {
            Console.WriteLine("Garage door is closed");
        }
    }
}
