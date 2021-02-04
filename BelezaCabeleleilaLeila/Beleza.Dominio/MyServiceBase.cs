using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BelezaCaleleleilaLeila.Dominio
{
    class MyServiceBase
    {
        public List<Service> Servicos { get; set; }

        public MyServiceBase()
        {
            Servicos = new List<Service>();
        }

        public void IncluirUmServico(Service serv)
        {
            Servicos.Add(serv);
        }

        public void AlterarUmServico(int id, string nomeNovo, int minutosParaExecucaoNovo, decimal precoNovo)
        {
            Service service = Servicos.FirstOrDefault();
            if (service != null)
            {
                service.AlterarUmServico(nomeNovo, minutosParaExecucaoNovo, precoNovo);
            }
        }

        public void ExcluirUmServico(int id)
        {
            Servicos.RemoveAll(serv => serv.IdServico == id);
        }
    }
}

