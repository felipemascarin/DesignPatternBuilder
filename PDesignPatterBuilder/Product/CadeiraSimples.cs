using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDesignPatterBuilder.Product
{
    internal class CadeiraSimples
    {
        public bool Encosto_de_Cabeca { get; set; }
        public string Assento { get; set; }
        public string Tipo_de_Braco { get; set; }
        public string Tipo_de_Perna { get; set; }
        public string Estofado { get; set; }
        public string Tipo_de_Material { get; set; }

        public override string ToString()
        {
            return $"\nCadeira Simples:\nEncosto de cabeça: {Encosto_de_Cabeca}\nAssento: {Assento}\nTipo de Braço: {Tipo_de_Braco}" +
                $"\nTipo de Perna: {Tipo_de_Perna}\nEstofado: {Estofado}\nTipo de Material: {Tipo_de_Material}\n";
        }
    }
}
