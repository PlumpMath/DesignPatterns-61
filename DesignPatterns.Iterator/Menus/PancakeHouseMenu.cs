using DesignPatterns.Iterator.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator.Menus
{
    public class PancakeHouseMenu : IMenu
    {
        private List<MenuItem> menuItems;

        public PancakeHouseMenu()
        {
            this.Name = "Pancake House Menu";
            this.menuItems = new List<MenuItem>();
            this.AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.95);
            this.AddItem("Blueberry Pancakes", "Pancakes with fresh blueberries", true, 3.45);
            this.AddItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.55);
        }

        public string Name { get; private set; }

        public void AddItem(string name, string description, bool isVegetarian, double price)
        {
            menuItems.Add(new MenuItem(name, description, isVegetarian, price));
        }

        public IIterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(menuItems);
        }
    }
}
