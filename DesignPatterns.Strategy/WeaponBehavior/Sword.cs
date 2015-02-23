using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.WeaponBehavior
{
    public class Sword : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Swinging a sword");
        }
    }
}
