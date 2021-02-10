using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BelezaCaleleleilaLeila.Dominio;

namespace BelezaCabeleleilaLeila
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var MyClients = IncluirMeusClientes();
                var MyServices = IncluirMeusServicos();
                var MyEmployees = IncluirFuncionarios(MyServices);
                var MySchedule = IncluirMeusAgendamentos();

                List<Schedule> agenda = new List<Schedule>();
                agenda.Add(new Schedule
                {
                    IdAgendamento = 2,
                    ServicoSolicitado =
                            new RequestedServices { IdServSolicitado = 2, ServSolicitado = MyServices.Servicos.First() },
                    DtAgendamento = new DateTime(2021, 1, 29, 12, 0, 0)
                });
                agenda.Add(new Schedule
                {
                    IdAgendamento = 2,
                    ServicoSolicitado =
                            new RequestedServices { IdServSolicitado = 3, ServSolicitado = MyServices.Servicos.First() },
                    DtAgendamento = new DateTime(2021, 1, 29, 11, 0, 0),
                    Status = Schedule.Sch_StatusAgenda.CanceladoPeloCliente
                });


                Schedule agendamento = new Schedule();
                agendamento.Sch_IncluirAgendamento(1, MyClients.Clientes.First(),
                    new RequestedServices { IdServSolicitado = 1, ServSolicitado = MyServices.Servicos.First() }, new DateTime(2021, 1, 29, 10, 0, 0),
                    agenda);
            }
            catch (IOException)
            {
                Console.WriteLine("Ocorreu um erro. Tente novamente mais tarde. ");
            }
            catch (ArgumentNullException nrEx)
            {
                Console.WriteLine("Aqui caiu a Null Reference!");
                throw;
            }
            catch (Exception)
            {
                Console.WriteLine("Deu ruim!!!");
                //throw;
            }
            Console.WriteLine("Continuando...");
            Console.ReadLine();
        }

        private static object IncluirMeusAgendamentos()
        {
            Schedule agenda = new Schedule();

            return new MySchedulingBase();
        }

        static MyCustomerBase IncluirMeusClientes()
        {
            Client c1 = new Client();
            c1.IncluirCliente(1, "Thamirys", "999999999", "12345678901");

            Client c2 = new Client();
            c2.IncluirCliente(2, "Thaise", "999999998", "12345678902");

            //MyServiceBase mc = new MyServiceBase();
            //mc.IncluirCliente(c1);
            //mc.IncluirCliente(c2);

            var c3 = new Client();
            c3.IncluirCliente(3, "Maria", "999999997", "12345678903");

            var c4 = new Client();
            c4.IncluirCliente(4, "Joana", "999999996", "12345678904");

            //mc.IncluirClienteNaLista(c3, c4);

            return new MyCustomerBase();
        }

        static MyServiceBase IncluirMeusServicos()
        {
            Service s1 = new Service();
            s1.IncluirUmServico(1, "Corte de Cabelo", 59, 130);

            Service s5 = new Service();
            s5.IncluirUmServico(1, "Corte de Cabelo", 59, 130);

            Service s2 = new Service();
            s2.IncluirUmServico(2, "Manicure", 59, 20);

            Service s3 = new Service();
            s3.IncluirUmServico(3, "Pedicure", 59, 30);

            Service s4 = new Service();
            s4.IncluirUmServico(4, "Limpeza de pele", 59, 100);


            MyServiceBase bs = new MyServiceBase();
            bs.IncluirUmServico(s1);
            bs.IncluirUmServico(s2);
            bs.IncluirUmServico(s3);
            bs.IncluirUmServico(s4);
            bs.IncluirUmServico(s5);

            return bs;
        }

        static MyCustomerBase IncluirFuncionarios(MyServiceBase baseDeServico)
        {
            Employee f1 = new Employee();
            Address e1 = new Address();
            e1.IncluirAddress(1, "Rua dos bobos", "12345-010", "Vila dos Devs", "São Paulo", "SP", "0");

            f1.IncluirFuncionario("Maria", "999999999", e1, Employee.CargoFunc.Cabelereira);

            Employee f2 = new Employee();
            f2.IncluirFuncionario("Rosana", "999999998", e1, Employee.CargoFunc.Manicure);

            Employee f3 = new Employee();
            f3.IncluirFuncionario("Joana", "999999997", e1, Employee.CargoFunc.Esteticista);

            MyCustomerBase bf = new MyCustomerBase();
            //bf.IncluirUmFuncionario(f1);
            //bf.IncluirUmFuncionario(f2);
            //bf.IncluirUmFuncionario(f3);


            //bf.IncluirServicoDeUmFuncionario(1, baseDeServico.Servicos.FirstOrDefault(x => x.IdServico == 1));
            //bf.IncluirServicoDeUmFuncionario(2, baseDeServico.Servicos.FirstOrDefault(x => x.IdServico == 2));
            //bf.IncluirServicoDeUmFuncionario(2, baseDeServico.Servicos.FirstOrDefault(x => x.IdServico == 3));
            //bf.IncluirServicoDeUmFuncionario(3, baseDeServico.Servicos.FirstOrDefault(x => x.IdServico == 4));

            return bf;
        }

        static void ChamarOExcluir()
        {

        }
    }
}
