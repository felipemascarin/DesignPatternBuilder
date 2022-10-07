using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDesignPatterBuilder.Interface
{
    internal interface Builder
    {
        public void Reset() { }
        public void MakeMaterialPrincipal() { }
        public void MakePernas() { }
        public void MakeAssento() { }
        public void MakeBracos() { }
        public void MakeEstofado() { }
        public void MakeEncosto() { }

    }
}
