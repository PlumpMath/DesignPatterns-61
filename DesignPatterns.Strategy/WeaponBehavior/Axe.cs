using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.WeaponBehavior
{
    public class Axe : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Chopping with axe");
        }
    }
}
