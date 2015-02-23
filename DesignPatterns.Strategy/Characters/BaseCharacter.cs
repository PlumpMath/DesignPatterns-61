using DesignPatterns.Strategy.WeaponBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Characters
{
    public abstract class BaseCharacter
    {
        public IWeaponBehavior Weapon { get; set; }

        public abstract void Fight();
    }
}
