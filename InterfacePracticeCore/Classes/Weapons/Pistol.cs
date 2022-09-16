using InterfacePracticeCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePracticeCore.Classes.Weapons
{
    public class Pistol : IWeapon
    {
        private int _durability = 100;
        private int _damage = 5;

        public int Damage { get => _damage; set => _damage = value; }
        public int Durability { get => _durability; set => _durability = value; }

        public void Reload()
        {
            Console.WriteLine("Pistol was reloaded!");
        }

        public void Repair()
        {
            Durability = 100;
            Console.WriteLine("Pistol was repaired!");
        }

        public void Shoot()
        {
            Console.WriteLine($"Pistol shooted and inflicted {Damage} damage!");
        }

        public void Upgrade()
        {
            Damage += 3;
            Console.WriteLine($"Pistol was upgraded. Now it's damage is {Damage}");
        }
    }
}
