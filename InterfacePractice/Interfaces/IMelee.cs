using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice.Interfaces
{
    internal interface IMelee : IRepairable
    {
        int Damage { get; set; }

        void Hit();
    }
}
