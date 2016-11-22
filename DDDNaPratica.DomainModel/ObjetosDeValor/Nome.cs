using System;

namespace DDDNaPratica.DomainModel.ObjetosDeValor
{
    public class Nome : ObjetoDeValor<Nome>
    {
        public string PrimeiroNome { get; }
        public string SobreNome { get; }

        public Nome(string primeiroNome, string sobreNome)
        {
            if (string.IsNullOrEmpty(primeiroNome))
                throw new InvalidOperationException("O primeiro nome é obrigatório. Não pode ser nulo ou vazio");

            if (string.IsNullOrWhiteSpace(primeiroNome))
                throw new InvalidOperationException("O primeiro nome é obrigatório. Não pode ser nulo ou conter espaços em branco");

            if (string.IsNullOrEmpty(sobreNome))
                throw new InvalidOperationException("O primeiro nome é obrigatório. Não pode ser nulo ou vazio");

            PrimeiroNome = primeiroNome;
            SobreNome = sobreNome;
        }

        public string ExibirNomeCompleto()
        {
            return $"{PrimeiroNome} {SobreNome}";
        }

        protected override bool EqualsCore(Nome other)
        {
            return PrimeiroNome == other.PrimeiroNome && SobreNome == other.SobreNome;
        }

        protected override int GetHashCodeCore()
        {
            unchecked
            {
                var hashcode = PrimeiroNome.GetHashCode();
                hashcode = (hashcode * 397) ^ SobreNome.GetHashCode();

                return hashcode;
            }
        }
    }
}
