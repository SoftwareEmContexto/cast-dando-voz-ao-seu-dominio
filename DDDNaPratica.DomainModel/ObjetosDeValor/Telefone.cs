using System;

namespace DDDNaPratica.DomainModel.ObjetosDeValor
{
    public class Telefone : ObjetoDeValor<Telefone>
    {
        public int DDD { get;}
        public string Numero { get; }

        public Telefone(int ddd, string numero)
        {
            if (ddd < 11 || ddd > 99)
                throw new InvalidOperationException("O ddd está inválido");

            if (string.IsNullOrWhiteSpace(numero))
                throw new InvalidOperationException("O número é obrigatório");

            if (numero.Length == 0 || numero.Length > 9)
                throw new InvalidOperationException("O número do telefone está inválido");

            Numero = numero;
            DDD = ddd;
        }

        protected override bool EqualsCore(Telefone other)
        {
            return Numero == other.Numero
                   && DDD == other.DDD;
        }

        protected override int GetHashCodeCore()
        {
            unchecked
            {
                int hashCode = Numero.GetHashCode();
                hashCode = (hashCode * 397) ^ DDD.GetHashCode();

                return hashCode;
            }
        }
    }
}
