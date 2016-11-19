using System;

namespace DDDNaPratica.DomainModel.ObjetosDeValor
{
    public class CPF : ObjetoDeValor<CPF>
    {
        public string Numero { get; }

        public CPF(string numeroDoCpf)
        {
            if (!validarCPF(numeroDoCpf))
                throw new InvalidOperationException("CPF inválido");

            Numero = numeroDoCpf;
        }

        protected override bool EqualsCore(CPF other)
        {
            return Numero == other.Numero;
        }

        protected override int GetHashCodeCore()
        {
            return Numero.GetHashCode();
        }

        private bool validarCPF(string CPF)
        {
            int[] mt1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mt2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string TempCPF;
            string Digito;
            int soma;
            int resto;

            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "").Replace("-", "");

            if (CPF.Length != 11)
                return false;

            TempCPF = CPF.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(TempCPF[i].ToString()) * mt1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            Digito = resto.ToString();
            TempCPF = TempCPF + Digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(TempCPF[i].ToString()) * mt2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            Digito = Digito + resto.ToString();

            return CPF.EndsWith(Digito);
        }
    }
}
