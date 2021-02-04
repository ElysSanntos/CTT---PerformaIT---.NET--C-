using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BelezaCaleleleilaLeila.Dominio
{
    class Schedule
    {
        

            /*
             Thamirys
                Progressiva / Maria - 14:00 - 4hs
                Manicure / Joana - 18:00 - 1h
                Corte Cabelo / Maria - 19:00 - 30           
             29/01/2021 as 14 hs
             A Realizar
             */


            public int IdAgendamento { get; set; }
            public Client Cliente { get; set; }
            //public List<ServicoSolicitado> ServicosSolicitados { get; set; }
            public RequestedServices ServicoSolicitado { get; set; }
            public DateTime? DtAgendamento { get; set; }
            public DateTime DataChegada { get; set; }
            public string Anotacao { get; set; }
            public StatusAgenda Status { get; set; }

            public enum StatusAgenda
            {
                ARealizar,
                Realizado,
                Reagendado,
                CanceladoPeloCliente,
                NaoCompareceu,
                CanceladoPeloSalao,
                Pendente
            }

            public string IncluirAgendamento(int id, Client cliente,
                //List<ServicoSolicitado> servicosSolicitados, 
                RequestedServices servicoParaAgendar,
                DateTime dtAgendamento, List<Schedule> agenda, string anotacao = "")
            {
                if (PermiteAgendar(agenda, servicoParaAgendar, dtAgendamento))
                {
                    return "Esse horário não está livre.";
                }
                else
                {
                    IdAgendamento = id;
                    Cliente = cliente;
                    //ServicosSolicitados = servicosSolicitados;
                    ServicoSolicitado = servicoParaAgendar;
                    DtAgendamento = dtAgendamento;
                    Anotacao = anotacao;

                    return "Agendamento feito com sucesso.";
                }
            }

            public string AlterarAgendamento(Client cliente, RequestedServices servicoParaAgendar,
                DateTime dtAgendamento, List<Schedule> agenda, string anotacao = "")
            {
                if (PermiteAgendar(agenda, servicoParaAgendar, dtAgendamento))
                {
                    return "Esse horário não está livre.";
                }
                else
                {
                    servicoParaAgendar.Status = ServicoSolicitado.StatusServico.Reagendado;
                    Cliente = cliente;
                    //ServicosSolicitados = servicosSolicitados;
                    ServicoSolicitado = servicoParaAgendar;
                    DtAgendamento = dtAgendamento;
                    Anotacao = anotacao;

                    return "Agendamento feito com sucesso.";
                }
            }

            private bool PermiteAgendar(List<Schedule> agenda, RequestedServices servicoParaAgendar, DateTime dtAgendamento)
            {
                DateTime dataTerminoParaAgendar = dtAgendamento.AddMinutes(servicoParaAgendar.Service.TempoDeExecucaoDeUmServico);
                return (agenda.Any(a => a.DtAgendamento >= dtAgendamento &&
                        (a.Status != StatusAgenda.CanceladoPeloSalao || a.Status != StatusAgenda.CanceladoPeloCliente)) &&
                    agenda.Any(a => a.DtAgendamento <= dataTerminoParaAgendar &&
                        (a.Status != StatusAgenda.CanceladoPeloSalao || a.Status != StatusAgenda.CanceladoPeloCliente)));
            }

            public void IncluirServicoSolicitado(int id, Service servico, Employee func)
            {
            RequestedServices ss = new RequestedServices();
                ss.IncluirServicoSolicitado(id, servico, func);
            //RequestedServices.Add(ss);
        }

        public void ExcluirServicoSolicitado(int id)
            {
                //ServicosSolicitados.RemoveAll(x => x.Id == id);
            }

        }
    }

