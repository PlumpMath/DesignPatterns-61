using DesignPatterns.AbstractFactory.Ingridients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public interface IPizzaIngridientFactory
    {
        Dough CreateDough();

        Sauce CreateSauce();

        Cheese CreateCheese();

        Clams CreateClams();
    }
}
