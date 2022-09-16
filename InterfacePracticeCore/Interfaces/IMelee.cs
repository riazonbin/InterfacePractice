using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePracticeCore.Interfaces
{
    public interface IMelee : IRepairable, IUpgradeable
    {
        int Damage { get; set; }

        void Hit();
    }
}
