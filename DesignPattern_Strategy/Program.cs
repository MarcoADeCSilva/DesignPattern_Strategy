using DesignPattern_Strategy.Dominio;
using DesignPattern_Strategy.Infraestrutura.Impostos;
using DesignPattern_Strategy.Interface;
using DesignPattern_Strategy.Servico;
using System;

namespace DesignPattern_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IImposto iss = new ISS();
            IImposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500.0);
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, icms);

            Console.ReadKey();
        }
    }
}
