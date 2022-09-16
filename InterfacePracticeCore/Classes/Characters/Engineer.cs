using InterfacePracticeCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePracticeCore.Classes.Characters
{
    public class Engineer
    {
        public void Repair(IRepairable repairableThing)
        {
            repairableThing.Repair();
        }

        public void Upgrade(IUpgradeable upgradableThing)
        {
            upgradableThing.Upgrade();
        }
    }
}
