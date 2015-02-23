using DesignPatterns.Iterator.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator.Menus
{
    public class DinerMenu : IMenu
    {
        private const int MaxItemsCount = 6;

        private int itemsCount = 0;

        private MenuItem[] menuItems;

        public DinerMenu()
        {
            this.Name = "Diner Menu";
            this.menuItems = new MenuItem[MaxItemsCount];
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.25);
            AddItem("Hotdog", "A hot dog, topped with cheese", false, 3.05);
        }

        public string Name { get; private set; }

        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(menuItems);
        }

        public void AddItem(string name, string description, bool isVegetarian, double price)
        {
            if (itemsCount >= MaxItemsCount)
            {
                Console.WriteLine("Sorry, menu is full! Can't add an item to the menu.");
                return;
            }

            menuItems[itemsCount] = new MenuItem(name, description, isVegetarian, price);
            itemsCount++;
        }
    }
}
