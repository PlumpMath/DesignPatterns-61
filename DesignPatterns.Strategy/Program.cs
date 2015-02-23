using DesignPatterns.Strategy.Characters;
using DesignPatterns.Strategy.WeaponBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    /// <summary>
    /// The strategy pattern defines a family of algorithms, encapsulates each one and makes them interchangeable.
    /// Strategy lets the algorithm vary independently from clients that use it.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var barbarian = new Barbarian();
            barbarian.Weapon = new Axe();

            var knight = new Knight();
            knight.Weapon = new Sword();

            barbarian.Fight();
            knight.Fight();
            Console.WriteLine();

            barbarian.Weapon = new Sword();
            knight.Weapon = new Knife();

            barbarian.Fight();
            knight.Fight();

            Console.ReadLine();
        }
    }
}
