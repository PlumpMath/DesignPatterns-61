using DesignPatterns.AbstractFactory.Ingridients.NY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.IngridientFactories
{
    public class NYPizzaIngridientFactory : IPizzaIngridientFactory
    {
        public Ingridients.Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Ingridients.Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Ingridients.Cheese CreateCheese()
        {
            return new RegianoCheese();
        }

        public Ingridients.Clams CreateClams()
        {
            return new FreshClams();
        }
    }
}
