using InterfacePracticeCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePracticeCore.Classes.Weapons
{
    public class AutomaticRifle : ITripleWeapon
    {
        private int _durability = 100;
        private int _damage = 5;

        public int Damage { get => _damage; set => _damage = value; }
        public int Durability { get => _durability; set => _durability = value; }

        public void Reload()
        {
            Console.WriteLine("Automatic rifle was reloaded!");
        }

        public void Repair()
        {
            Durability = 100;
            Console.WriteLine("Automatic rifle was repaired!");
        }

        public void Shoot()
        {
            Console.WriteLine($"Automatic rifle shooted and inflicted {Damage} damage!");
        }

        public void MultiShoot()
        {
            Console.WriteLine($"Automatic rifle shooted many times and each shot inflicted {Damage} damage!");
        }

        public void Upgrade()
        {
            Damage += 3;
            Console.WriteLine($"Automatic rifle was upgraded. Now it's damage is {Damage}");
        }
    }
}
