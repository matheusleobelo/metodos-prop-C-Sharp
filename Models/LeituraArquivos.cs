using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class LeituraArquivos
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeDeLinhas) LerArquivos(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch
            {
                return (false, new string[0], 0);
            }
        }
    }
}