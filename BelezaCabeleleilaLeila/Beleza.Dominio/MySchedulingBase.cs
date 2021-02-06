using System;
using System.Collections.Generic;
using System.Text;

namespace BelezaCaleleleilaLeila.Dominio
{
    public class MySchedulingBase
    {
        public List<Schedule> Agendamentos { get; set; }

        public bool AgendarServicos(int id, Client cliente, List<RequestedServices> servicosSolicitados,
            DateTime dtAgendamento, string anotacao = "")
        {
            Schedule agenda = new Schedule();
            //agenda.IncluirAgendamento(id, cliente, servicosSolicitados, dtAgendamento, anotacao);
            return true;
        }
    }
}
