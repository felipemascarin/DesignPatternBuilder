using System;
using PDesignPatterBuilder.Builders;
using PDesignPatterBuilder.Product;
using PDesignPatterBuilder.Interface;

namespace PDesignPatterBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var builder = new ConcreteBuilderCadeiraSimples();
            var director = new Director(builder);
            director.MakeCadeira();
            CadeiraSimples cadeirasimples = builder.GetResult();



            var build = new ConcreteBuilderCadeiraEscritorio();
            director = new Director(build);
            director.MakeCadeira();
            CadeiraEscritorio cadeiraescritorio = build.GetResult();



            Console.WriteLine(cadeirasimples.ToString());
            Console.WriteLine(cadeiraescritorio.ToString());

        }
    }
}
