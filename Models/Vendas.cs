using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Vendas
    {
        public Vendas(int quantidade, string nome, decimal preco)
        {
            Quantidade = quantidade;
            Nome = nome;
            Preco = preco;
        }
        public int Quantidade { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}