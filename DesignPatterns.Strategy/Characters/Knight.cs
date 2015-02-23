using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Characters
{
    public class Knight : BaseCharacter
    {
        public override void Fight()
        {
            Console.WriteLine("Horse riding");
            Weapon.UseWeapon();
        }
    }
}
