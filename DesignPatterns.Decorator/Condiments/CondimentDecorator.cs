using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Condiments
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage Beverage { get; set; }

        public CondimentDecorator(Beverage beverage)
        {
            this.Beverage = beverage;
        }
    }
}
