﻿namespace MBCorpHealthTest.Dominio.Entidades
{
    public class Atendente
    {
        public Atendente()
        {
        }

        public Atendente(string cpf, string nome)
        {
            CPF = cpf;
            Nome = nome;
        }

        public string CPF { get; protected set; }
        public string Nome { get; protected set; }

        //todo Criar validação
    }
}