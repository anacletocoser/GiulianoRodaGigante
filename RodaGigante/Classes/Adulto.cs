using System;
using System.Collections.Generic;
using System.Text;

namespace RodaGigante
{
    public class Adulto : Pessoa
    {               
        public Adulto(string nome, int idade) : base(nome, idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
