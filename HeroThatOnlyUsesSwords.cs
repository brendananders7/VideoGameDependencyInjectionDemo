using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameDependencyInjectionDemo
{
    class HeroThatOnlyUsesSwords : IHero
    {
        public HeroThatOnlyUsesSwords(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Attack()
        {
            Sword sword = new Sword("Excalibur");
            Console.WriteLine(Name + " prepares himself for battle.");
            sword.AttackWithMe();
        }
    }
}
