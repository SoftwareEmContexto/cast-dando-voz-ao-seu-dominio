using System;
using System.Text.RegularExpressions;

namespace DDDNaPratica.DomainModel.ObjetosDeValor
{
    public class Email : ObjetoDeValor<Email>
    {
        public string Endereco { get; }

        public Email(string enderecoDeEmail)
        {
            if (!(ValidarEnderecoDeEmail(enderecoDeEmail)))
                throw new InvalidOperationException("Endereço de email inválido");

            Endereco = enderecoDeEmail;
        }

        protected override bool EqualsCore(Email other)
        {
            throw new NotImplementedException();
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }

        private bool ValidarEnderecoDeEmail(string emailAddress)
        {
            string regexPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            Match matches = Regex.Match(emailAddress, regexPattern);
            return matches.Success;
        }
    }
}