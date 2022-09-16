using InterfacePracticeCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePracticeCore.Classes.Weapons
{
    public class Baton : IMelee
    {
        private int _durability = 100;
        private int _damage = 5;

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public int Durability
        {
            get => _durability;
            set
            {
                _durability = value;
            }
        }

        public void Hit()
        {
            if (Durability < 0)
            {
                Console.WriteLine("Baton is broken! You must repair it to attack!");
                return;
            }

            Console.WriteLine($"Baton inflicted {Damage} damage!");
            Durability -= 3;
        }
        public void Repair()
        {
            Durability = 100;
            Console.WriteLine($"Baton was repaired!");
        }

        public void Upgrade()
        {
            Damage += 3;

            Console.WriteLine($"Baton was upgraded! Now his damage is {Damage} when hitting!");
        }
    }
}
