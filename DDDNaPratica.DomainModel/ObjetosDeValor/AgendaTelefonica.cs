using System;

namespace DDDNaPratica.DomainModel.ObjetosDeValor
{
    public class AgendaTelefonica : ObjetoDeValor<AgendaTelefonica>
    {
        public Telefone TelefonePrincipal { get; }
        public Telefone TelefoneComercial { get; }
        public Telefone Celular { get; }

        public AgendaTelefonica(Telefone telefonePrincipal,
            Telefone telefoneComercial, Telefone celular)
        {
            if (telefonePrincipal == null)
                throw new InvalidOperationException("O telefone principal é obrigatório");

            if (celular == null)
                throw new InvalidOperationException("O celular é obrigatório");

            TelefonePrincipal = telefonePrincipal;
            TelefoneComercial = telefoneComercial;
            Celular = celular;
        }

        protected override bool EqualsCore(AgendaTelefonica other)
        {
            return TelefonePrincipal == other.TelefonePrincipal
                    && TelefoneComercial == other.TelefoneComercial
                    && Celular == other.Celular;
        }

        protected override int GetHashCodeCore()
        {
            unchecked
            {
                int hashCode = TelefonePrincipal.GetHashCode();
                hashCode = (hashCode * 397) ^ TelefoneComercial.GetHashCode();
                hashCode = (hashCode * 397) ^ Celular.GetHashCode();

                return hashCode;
            }
        }
    }
}