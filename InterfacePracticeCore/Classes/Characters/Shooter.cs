using InterfacePracticeCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePracticeCore.Classes.Characters
{
    public class Shooter
    {
        List<IWeapon> listOfWeapons = new List<IWeapon>();

        public void PickUpWeapon(IWeapon weapon)
        {
            listOfWeapons.Add(weapon);
        }

        public void UseAllWeaponsFromInventory()
        {
            foreach(var weapon in listOfWeapons)
            {
                weapon.Shoot();
            }
        }
        public void SingleShoot(IWeapon weapon)
        {
            weapon.Shoot();
        }
        public void MultiShoot(ITripleWeapon weapon)
        {
            weapon.MultiShoot();
        }

        public void Reload(IWeapon weapon)
        {
            weapon.Reload();
        }

        public void HitMelee(IMelee meleeWeapon)
        {
            meleeWeapon.Hit();
        }

        public void ThrowMelee(IThrowable throwableWeapon)
        {
            throwableWeapon.Throw();
        }
    }
}
