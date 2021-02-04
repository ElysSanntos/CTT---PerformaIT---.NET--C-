using System;
using System.Collections.Generic;
using System.Text;

namespace BelezaCaleleleilaLeila.Dominio
{
    class Service
    {
        public int IdServico { get; set; }
        public string NomeServico { get; set; }
        public int TempoDeExecucaoDeUmServico { get; set; }
        public decimal ValorDoServico { get; set; }

        public void IncluirUmServico(int id, string nome, int minutosParaExecucao, decimal preco)
        {
            Schedule a = new Schedule();

            IdServico = id;
            NomeServico = nome;
            TempoDeExecucaoDeUmServico = minutosParaExecucao;
            ValorDoServico = preco;
        }

        public void AlterarUmServico(string nome, int minutosParaExecucao, decimal preco)
        {
            NomeServico = nome;
            TempoDeExecucaoDeUmServico = minutosParaExecucao;
            ValorDoServico = preco;
        }

    }
}

