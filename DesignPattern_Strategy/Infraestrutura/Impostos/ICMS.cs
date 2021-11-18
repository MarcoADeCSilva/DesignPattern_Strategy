using DesignPattern_Strategy.Dominio;
using DesignPattern_Strategy.Interface;

namespace DesignPattern_Strategy.Infraestrutura.Impostos
{
    public class ICMS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return ((orcamento.Valor * 0.05) + 50.00);
        }
    }
}
