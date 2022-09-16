using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePracticeCore.Interfaces
{
    public interface IThrowable : IRepairable, IUpgradeable
    {
        public int ThrowDamage { get; set; }
        void Throw();
    }
}
