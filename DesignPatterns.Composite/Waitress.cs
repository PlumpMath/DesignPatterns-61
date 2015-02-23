using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Waitress
    {
        private MenuComponent allMenus;

        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public void PrintMenu()
        {
            allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            Console.WriteLine("\nVEGETARIAN MENU\n-----");
            foreach (var component in allMenus)
            {
                try
                {
                    if (component.IsVegetarian)
                    {
                        component.Print();
                    }
                }
                catch (InvalidOperationException) { }
            }
        }
    }
}
