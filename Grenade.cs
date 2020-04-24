using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameDependencyInjectionDemo
{
    class Grenade : IWeapon
    {
        public Grenade(string weaponName)
        {
            WeaponName = weaponName;
        }

        public string WeaponName { get; set; }

        public void AttackWithMe()
        {
            Console.WriteLine(WeaponName + " sizzles for a moment, then explodes into a shower of deadly metal fragments.");
        }
    }
}
