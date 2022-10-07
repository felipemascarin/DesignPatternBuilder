using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDesignPatterBuilder.Interface;

namespace PDesignPatterBuilder.Builders
{
    internal class Director
    {
        public Builder Builder { get; set; }

        public Director(Builder builder)
        {
            Builder = builder;
        }

        public void MakeCadeira()
        {
            Builder.Reset();
            Builder.MakeMaterialPrincipal();
            Builder.MakePernas();
            Builder.MakeAssento();
            Builder.MakeBracos();
            Builder.MakeEstofado();
            Builder.MakeEncosto();
        }


    }
}
