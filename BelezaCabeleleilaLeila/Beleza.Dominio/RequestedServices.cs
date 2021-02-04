using System;
using System.Collections.Generic;
using System.Text;

namespace BelezaCaleleleilaLeila.Dominio
{
    class RequestedServices
    {
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
