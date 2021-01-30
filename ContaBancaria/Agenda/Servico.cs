using System;
using System.Collections.Generic;
using System.Text;

namespace Manicure
{
    class Servico
    {
        public int IdServico { get; set; }
        public string NomeServico { get; set; }
        public int MinutosServico { get; set; }
        public decimal Valorservico { get; set; }
        public void Incluir(int id,string nome,int tempoDeExecucao,decimal preco)
        {
            IdServico = id;
            NomeServico = nome;
            MinutosServico = tempoDeExecucao;
            Valorservico = preco;
        }
        public void Alterar(string nome, int tempoDeExecucao, decimal preco)
        {
            
            NomeServico = nome;
            MinutosServico = tempoDeExecucao;
            Valorservico = preco;
        }
    }
}
