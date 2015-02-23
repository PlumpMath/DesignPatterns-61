using DesignPatterns.AbstractFactory.Ingridients.Chicago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.IngridientFactories
{
    public class ChicagoPizzaIngridientFactory : IPizzaIngridientFactory
    {
        public Ingridients.Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Ingridients.Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public Ingridients.Cheese CreateCheese()
        {
            return new MozarellaCheese();
        }

        public Ingridients.Clams CreateClams()
        {
            return new FrozenClams();
        }
    }
}
