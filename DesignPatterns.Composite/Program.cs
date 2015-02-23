using DesignPatterns.Composite.MenuComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var pancakeHouseMenu = new Menu("Pancake House Menu", "Breakfast");
            var dinerMenu = new Menu("Diner Menu", "Lunch");
            var dessertMenu = new Menu("Dessert Menu", "Dessert!");

            var allMenus = new Menu("All Menus", "All menus combined");
            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);

            pancakeHouseMenu.Add(new MenuItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.95));
            pancakeHouseMenu.Add(new MenuItem("Blueberry Pancakes", "Pancakes with fresh blueberries", true, 3.45));
            pancakeHouseMenu.Add(new MenuItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.55));

            dinerMenu.Add(new MenuItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.25));
            dinerMenu.Add(new MenuItem("Hotdog", "A hot dog, topped with cheese", false, 3.05));
            dinerMenu.Add(new MenuItem("Pasta", "Spaghetti with Marinara Sauce", true, 3.85));

            dinerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuItem("Apple Pie", "Apple pie with a flakey crust, topped with vanilla icecream", true, 1.55));
            dessertMenu.Add(new MenuItem("Cheesecake", "Creamy New York Cheesecake, with a chocolate graham crust", true, 1.95));

            var waitress = new Waitress(allMenus);
            waitress.PrintMenu();
            waitress.PrintVegetarianMenu();

            Console.ReadLine();
        }
    }
}
