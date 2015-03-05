using DesignPatterns.Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    /// <summary>
    /// The builder pattern encapsulates the construction of a product and allows it to be constructed in steps
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder;
            var shop = new Shop();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            Console.WriteLine();

            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            Console.ReadLine();
        }
    }
}
