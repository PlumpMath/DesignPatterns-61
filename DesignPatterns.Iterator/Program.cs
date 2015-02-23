using DesignPatterns.Iterator.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    /// <summary>
    /// The iterator pattern provides a way to access the elements of an aggregare object sequentially
    /// without exposing its underlying representation
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();
            var waitress = new Waitress(new List<IMenu>() { pancakeHouseMenu, dinerMenu });
            waitress.PrintMenu();
        }
    }
}
