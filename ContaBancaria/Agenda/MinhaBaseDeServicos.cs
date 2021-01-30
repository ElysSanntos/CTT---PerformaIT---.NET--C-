using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manicure
{
    class MinhaBaseDeServicos
    {
        public List<Servico> Servicos { get; set; }

        public MinhaBaseDeServicos()
        {
            Servicos = new List<Servico>();
        }

        public void Incluir(Servico baseServico)
        {
            Servicos.Add(baseServico);
        }

        public void AlterarUmServico(int id, string nomeNovo, int minutosParaExecucaoNovo, decimal precoNovo)
        {
            Servico servico = Servicos.FirstOrDefault();
            if (servico != null)
            {
                servico.Alterar(nomeNovo, minutosParaExecucaoNovo, precoNovo);
            }
        }

        public void ExcluirUmServico(int id)
        {
            
            Servicos.RemoveAll(serv => serv.IdServico == id);
        }
    }
}
