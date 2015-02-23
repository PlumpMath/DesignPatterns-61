using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Condiments
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) : base(beverage) { }

        public override string Description
        {
            get { return this.Beverage.Description + ", Milk"; }
        }

        public override double Cost
        {
            get { return this.Beverage.Cost + 1.1; }
        }
    }
}
