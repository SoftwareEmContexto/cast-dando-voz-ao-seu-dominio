using System;

namespace DDDNaPratica.DomainModel.ObjetosDeValor
{
    public class Idade : ObjetoDeValor<Idade>
    {
        public DateTime DataDeNascimento { get; }
        public int Valor => DateTime.Now.Year - DataDeNascimento.Year;

        public Idade(DateTime dataDeNascimento)
        {
            DataDeNascimento = dataDeNascimento;
        }

        protected override bool EqualsCore(Idade other)
        {
            return DataDeNascimento == other.DataDeNascimento;
        }

        protected override int GetHashCodeCore()
        {
            return DataDeNascimento.GetHashCode();
        }
    }
}
