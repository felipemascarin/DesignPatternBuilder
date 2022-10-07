using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDesignPatterBuilder.Product
{
    internal class CadeiraEscritorio
    {
        public bool AlmofadaLombar { get; set; }
        public bool RegulagemAltura { get; set; }
        public string Tipo_de_Braco { get; set; }
        public string EncaixeRodinhas { get; set; }
        public string Estofado { get; set; }
        public string Tipo_de_Material { get; set; }

        public override string ToString()
        {
            return $"\nCadeira De Escritório:\nAlmofada Lombar: {AlmofadaLombar}\nRegulagem de Altura: {RegulagemAltura}" +
               $"\nTipo de Braço: {Tipo_de_Braco}" +
                $"\nTipo de Encaixe das Rodinhas: {EncaixeRodinhas}" +
                $"\nEstofado: {Estofado}\nTipo de Material: {Tipo_de_Material}\n";
        }
    }
}
