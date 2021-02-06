using System;
using System.Collections.Generic;
using System.Text;

namespace BelezaCaleleleilaLeila.Dominio
{
    public class RequestedServices
    {
        public object Status { get;  set; }
        public object StatusServico { get; set; }

        public class ServicoSolicitado
        {
            public int IdServSolicitado { get; set; }
            public Service Servico { get; set; }
            public Employee Funcionario { get; set; }
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

            public void IncluirServicoSolicitado(int id, Service servico, Employee func)
            {
                IdServSolicitado = id;
                Servico = servico;
                Funcionario = func;
            }
        }
    }
}
