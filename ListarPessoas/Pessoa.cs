using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoas
{
    internal class Pessoa
    {
        public int idade;
        public string nome;
        public char sexo;

        public Pessoa(int idade, string nome, char sexo)
        {
            this.idade = idade;
            this.nome = nome;
            this.sexo = sexo;
        }

        public string listarInformacoes()
        {
            return $"{nome} tem {idade} anos de idade e é do sexo {sexo}";
        }
    }
}
