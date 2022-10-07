using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDesignPatterBuilder.Interface;
using PDesignPatterBuilder.Product;

namespace PDesignPatterBuilder.Builders
{
    internal class ConcreteBuilderCadeiraSimples : Builder
    {

        public CadeiraSimples cadeirasimples { get; set; }

        public void Reset()
        {
            cadeirasimples = new CadeiraSimples();
        }

        public void MakeMaterialPrincipal()
        {
            cadeirasimples.Tipo_de_Material = "Madeira";
        }

        public void MakePernas()
        {
            cadeirasimples.Tipo_de_Perna = "4 Pernas retas cilíndricas na vertical";
        }

        public void MakeAssento()
        {
            cadeirasimples.Assento = "De madeira com estofado";
        }

        public void MakeBracos()
        {
            cadeirasimples.Tipo_de_Braco = "Não ajustáveis sem almofada no encosto";
        }

        public void MakeEstofado()
        {
            cadeirasimples.Estofado = "Espuma com acabamento de costura";
        }

        public void MakeEncosto()
        {
            cadeirasimples.Encosto_de_Cabeca = true;
        }





        public CadeiraSimples GetResult()
        {
            return cadeirasimples;
        }


    }
}
