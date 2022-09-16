using InterfacePracticeCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePracticeCore.Classes.Weapons
{
    public class Knife : IMelee, IThrowable
    {
        private int _durability = 100;
        private int _damage = 5;
        private int _throwingDamage = 4;

        public int Damage 
        {
            get { return _damage; }
            set { _damage = value; }
        }
        
        public int ThrowDamage
        {
            get { return _throwingDamage; }
            set { _throwingDamage = value; }
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
            if(Durability < 0)
            {
                Console.WriteLine("Knife is broken! You must repair it to attack!");
                return;
            }

            Console.WriteLine($"Knife inflicted {Damage} damage!");
            Durability -= 3;
        }

        public void Throw()
        {
            if (Durability < 0)
            {
                Console.WriteLine("Knife is broken! You must repair it to throw it!");
                return;
            }

            Console.WriteLine($"Knife inflicted {ThrowDamage} damage while being thrown!");
            Durability -= 3;
        }

        public void Repair()
        {
            Durability = 100;
            Console.WriteLine($"Knife was repaired!");
        }

        public void Upgrade()
        {
            Damage += 3;
            ThrowDamage += 2;

            Console.WriteLine($"Knife was upgraded! Now his damage is {Damage} when hitting and {ThrowDamage} when throwing!");
        }
    }
}
