using DesignPattern_Strategy.Dominio;
using DesignPattern_Strategy.Interface;

namespace DesignPattern_Strategy.Infraestrutura.Impostos
{
    public class ISS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
