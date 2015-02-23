using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Characters
{
    public class Barbarian : BaseCharacter
    {
        public override void Fight()
        {
            Console.WriteLine("Jumping");
            Console.WriteLine("Making an awful sound");
            Weapon.UseWeapon();
        }
    }
}
