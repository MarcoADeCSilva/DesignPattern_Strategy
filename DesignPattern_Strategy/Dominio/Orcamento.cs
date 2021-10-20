namespace DesignPattern_Strategy.Dominio
{
    public class Orcamento
    {
        public Orcamento(double valor)
        {
            Valor = valor;
        }

        public double Valor { get; private set; }
    }
}
