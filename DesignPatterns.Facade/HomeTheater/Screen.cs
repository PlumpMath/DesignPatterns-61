using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.HomeTheater
{
    public class Screen
    {
        public void Up()
        {
            Console.WriteLine("Screen is up");
        }

        public void Down()
        {
            Console.WriteLine("Screen is down");
        }
    }
}
