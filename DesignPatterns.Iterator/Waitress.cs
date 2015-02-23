using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class Waitress
    {
        private List<IMenu> menus;

        public Waitress(List<IMenu> menus)
        {
            this.menus = menus;
        }

        public void PrintMenu()
        {
            foreach (var menu in menus)
            {
                Console.WriteLine(menu.Name);
                Console.WriteLine("-------------------");
                var iterator = menu.CreateIterator();
                while (iterator.HasNext())
                {
                    var menuItem = (MenuItem)iterator.Next();
                    Console.WriteLine("{0}, {1} \n    -- {2}", menuItem.Name, menuItem.Price, menuItem.Description);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
