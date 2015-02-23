using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Beverages
{
    public class Expresso : Beverage
    {
        public override string Description
        {
            get { return "Espresso"; }
        }

        public override double Cost
        {
            get { return 3.5; }
        }
    }
}
