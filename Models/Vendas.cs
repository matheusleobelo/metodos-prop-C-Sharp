using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Vendas
    {
        public Vendas(int quantidade, string nome, decimal preco, DateTime data)
        {
            Quantidade = quantidade;
            Nome = nome;
            Preco = preco;
            Data = data;

        }
        public int Quantidade { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public DateTime Data { get; set; }
    }
}