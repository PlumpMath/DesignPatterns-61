using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Beverages
{
    public class Decaf : Beverage
    {
        public override string Description
        {
            get { return "Decaf"; }
        }

        public override double Cost
        {
            get { return 2.3; }
        }
    }
}
