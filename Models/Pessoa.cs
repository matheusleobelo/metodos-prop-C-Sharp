using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void Deconstruct(out string nome, out int idade)
        {
            nome = Nome;
            idade = Idade;
        }
        public string Nome
        {
            get => _nome.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        public int Idade {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Não existe idade negativa");
                }
                _idade = value;

             } }
        private string _nome;
        private int _idade;


        public void Apresentar()
        {
            Console.WriteLine($"Olá {Nome} que bom saber que você tem {Idade} anos");
        }
    }
}