using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameDependencyInjectionDemo
{
    class Sword : IWeapon
    {
        public Sword(string swordName)
        {
            SwordName = swordName;
        }

        public string SwordName { get; set; }

        public void AttackWithMe()
        {
            Console.WriteLine(SwordName + " slices through the air, devastating all enemies");
        }

    }
}
