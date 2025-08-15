using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Vendas
    {
        public Vendas(int quantidade, string nome, decimal preco,decimal? desconto, DateTime data)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
            Quantidade = quantidade;
            Data = data;

        }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public decimal? Desconto { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }

    }
}