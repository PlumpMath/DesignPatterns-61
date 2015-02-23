using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Condiments
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage) { }

        public override string Description
        {
            get { return Beverage.Description + ", Whip"; }
        }

        public override double Cost
        {
            get { return Beverage.Cost + 1.5; }
        }
    }
}
