using System;
using System.Collections.Generic;
using System.Text;

namespace BelezaCaleleleilaLeila.Dominio
{
    public class RequestedServices
    {

        public int IdServSolicitado { get; set; }
        public Service ServSolicitado { get; set; }
        public Employee Funcionario { get; set; }
        public RS_StatusServico Status { get; set; }
        public DateTime DtServicoSolicitado { get; set; }


        public enum RS_StatusServico
        {
            ARealizar,
            Realizado,
            Reagendado,
            CanceladoPeloCliente,
            CanceladoPeloSalao
        }

        public void RS_IncluirServicoSolicitado(int id, Service servico, Employee func)
        {
            IdServSolicitado = id;
            ServSolicitado = servico;
            Funcionario = func;

        }
    }
}



