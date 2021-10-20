using DesignPattern_Strategy.Dominio;
using DesignPattern_Strategy.Interface;
using System;

namespace DesignPattern_Strategy.Servico
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double valor = imposto.Calcula(orcamento);

            Console.WriteLine(valor);
        }
    }
}
