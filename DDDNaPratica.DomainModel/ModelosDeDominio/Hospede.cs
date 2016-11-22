﻿using DDDNaPratica.DomainModel.ObjetosDeValor;
using System;

namespace DDDNaPratica.DomainModel
{
    public class Hospede : Entidade
    {
        public Nome Nome { get; set; }

        public Idade Idade { get; set; }
        public CPF Cpf { get; set; }
        public Email Email { get; set; }

        public Endereco Endereco { get; set; }

        public AgendaTelefonica AgendaTelefonica { get; set; }

        public Hospede(CPF cpf, Idade idade, AgendaTelefonica agenda,
            Endereco endereco, Email email, Nome nome)
        {
            if (idade.Valor < 18)
                throw new InvalidOperationException();

            Cpf = cpf;
            Idade = idade;
            AgendaTelefonica = agenda;
            Endereco = endereco;
            Email = email;
            Nome = nome;
        }
    }
}