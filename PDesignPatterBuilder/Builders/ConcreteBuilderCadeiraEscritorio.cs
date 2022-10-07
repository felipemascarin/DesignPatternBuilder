using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDesignPatterBuilder.Interface;
using PDesignPatterBuilder.Product;

namespace PDesignPatterBuilder.Builders
{
    internal class ConcreteBuilderCadeiraEscritorio : Builder
    {
        public CadeiraEscritorio cadeiraescritorio { get; set; }

        public void Reset()
        {
            cadeiraescritorio = new CadeiraEscritorio();
        }

        public void MakeMaterialPrincipal()
        {
            cadeiraescritorio.Tipo_de_Material = "Plástico e Madeira";
        }

        public void MakePernas()
        {
            cadeiraescritorio.EncaixeRodinhas = "Parafusada";
        }

        public void MakeAssento()
        {
            cadeiraescritorio.RegulagemAltura = true;
        }

        public void MakeBracos()
        {
            cadeiraescritorio.Tipo_de_Braco = "Ajustável com almofada no encosto";
        }

        public void MakeEstofado()
        {
            cadeiraescritorio.Estofado = "Espuma com acabamento de costura";
        }

        public void MakeEncosto()
        {
            cadeiraescritorio.AlmofadaLombar = true;
        }





        public CadeiraEscritorio GetResult()
        {
            return cadeiraescritorio;
        }
    }
}
