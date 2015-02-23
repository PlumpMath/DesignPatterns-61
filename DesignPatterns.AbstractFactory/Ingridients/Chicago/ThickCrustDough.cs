using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Ingridients.Chicago
{
    public class ThickCrustDough : Dough
    {
        public ThickCrustDough()
        {
            this.DoughName = "Thick Crust";
        }
    }
}
