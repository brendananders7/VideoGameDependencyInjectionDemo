using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace VideoGameDependencyInjectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            UnityContainer container = new UnityContainer();

            //all weapons are considered swords by default
            container.RegisterType<IWeapon, Sword>(new InjectionConstructor("Slasher"));
            container.RegisterType<IHero, HeroThatCanUseAnyWeapon>(new InjectionConstructor("Sword Swinger", typeof(IWeapon)));

            var hero5 = container.Resolve<IHero>();

            hero5.Attack();
            Console.WriteLine();



            HeroThatOnlyUsesSwords hero1 = new HeroThatOnlyUsesSwords("Ultraman");

            hero1.Attack();
            Console.WriteLine();

            HeroThatCanUseAnyWeapon hero2 = new HeroThatCanUseAnyWeapon("SuperGreatMan", new Grenade("Pineapple"));
            hero2.Attack();
            Console.WriteLine();

            HeroThatCanUseAnyWeapon hero3 = new HeroThatCanUseAnyWeapon("Sword Swinger", new Sword("Brisingr"));
            hero3.Attack();
            Console.WriteLine();

            HeroThatCanUseAnyWeapon hero4 = new HeroThatCanUseAnyWeapon("GI Joe", new Gun("Six Shooter", new List<Bullet> { new Bullet("silver", 10), new Bullet("lead", 20), new Bullet("dead aim", 3), new Bullet("Hollow Point", 5)}));

            hero4.Attack();
            hero4.Attack();
            hero4.Attack();
            hero4.Attack();
            hero4.Attack();
            hero4.Attack();
            hero4.Attack();
            hero4.Attack();

            Console.ReadLine();
        }
    }
}
