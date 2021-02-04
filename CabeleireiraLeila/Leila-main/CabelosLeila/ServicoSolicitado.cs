using System;

namespace Leila.Dominio
{
    public class ServicoSolicitado
    {
        public int IdServSolicitado { get; set; }
        public Servico Servico { get; set; }
        public Funcionario Funcionario { get; set; }
        public StatusServico Status { get; set; }
        public DateTime DtServicoSolicitado { get; set; }

        public enum StatusServico
        {
            ARealizar,
            Realizado,
            Reagendado,
            CanceladoPeloCliente,           
            CanceladoPeloSalao
        }

        public void IncluirServicoSolicitado(int id, Servico servico, Funcionario func)
        {
            IdServSolicitado = id;
            Servico = servico;
            Funcionario = func;
        }
    }
}
