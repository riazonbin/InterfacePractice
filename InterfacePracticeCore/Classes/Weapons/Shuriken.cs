using InterfacePracticeCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePracticeCore.Classes.Weapons
{
    public class Shuriken : IThrowable
    {
        private int _durability = 100;
        private int _throwingDamage = 4;


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

        public void Throw()
        {
            if (Durability < 0)
            {
                Console.WriteLine("Shuriken is broken! You must repair it to throw it!");
                return;
            }

            Console.WriteLine($"Shuriken inflicted {ThrowDamage} damage while being thrown!");
            Durability -= 3;
        }

        public void Repair()
        {
            Durability = 100;
            Console.WriteLine($"Shuriken was repaired!");
        }

        public void Upgrade()
        {
            ThrowDamage += 2;

            Console.WriteLine($"Shuriken was upgraded! Now it's damage is {ThrowDamage} when throwing!");
        }
    }
}
