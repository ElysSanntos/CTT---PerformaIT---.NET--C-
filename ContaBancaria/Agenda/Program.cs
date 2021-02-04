
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

using static Manicure.Funcionario;

namespace Manicure
{
    public class Program
    {
        

        public static string NomeCliente { get; set; }

        static void Main(string[] args)
        {
            try
            {
                //Chamando os metodos aqui
                //No Try colocar todo o passo a passo do sistema
                var meusClientes = IncluirMeusClientes();
                Console.WriteLine("Incluir Cliente ok!");
                var meusServicos = IncluirMeusServicos();
                Console.WriteLine("Incluir Serviço ok!");
                var meusFuncionarios = IncluirFuncionarios(meusServicos);
                Console.WriteLine("Incluir Funcionario e Serviço ok!");

                //meusFuncionarios.ExcluirServicoDeUmFuncionario(1, 1);
                //meusClientes.AlterarUmCliente(1, "Elys", "2345-2345", "");
                //meusClientes.ExcluirUmCliente(2);
            }
            catch (IOException)
            {
                Console.WriteLine("ocorreu um erro, tente mais tarde!");
            }
            catch (NullReferenceException nrEx)
            {
                //Catch é executado em caso de exeção - caso algum passo do Try, dê erro
                Console.WriteLine("System.NullReferenceException: 'Object reference not " +
                    "set to an instance of an object.Manicure.Funcionario.Servicos.get retornou null.");
                //nrEx.StackTrace
                throw;

                Console.ReadLine();
                //throw;
            }
            catch (Exception)
            {
                Console.WriteLine("Deu ruim aqui!");
            }
            Console.WriteLine("Continuando....");


            
            

        }
        Funcionario funcionario = new Funcionario();
       
       

        static MinhaBaseDeClientes IncluirMeusClientes()
            {
                Cliente cliente1 = new Cliente();
                cliente1.Incluir(1, "Thamirys", "3456-3456", "");
                Cliente cliente2 = new Cliente();
                cliente2.Incluir(2, "Thaise", "4567-4567", "");

                MinhaBaseDeClientes baseClients = new MinhaBaseDeClientes();
                baseClients.IncluirCliente(cliente1);
                baseClients.IncluirCliente(cliente2);

                var cliente3 = new Cliente();
                cliente3.Incluir(3, "Maria", "5678-5678", "");
                var c4 = new Cliente();
                c4.Incluir(4, "Joana", "6789-6789", "");

                baseClients.IncluirLista(cliente3, c4);

                return baseClients;

            }
        static MinhaBaseDeServicos IncluirMeusServicos()
        {
            Servico service1 = new Servico();
            service1.IncluirServico(1,"Corte de Cabelos", 60, 120);
            Servico service2 = new Servico();
            service2.IncluirServico(2,"Manicure", 60, 20);
            Servico service3 = new Servico();
            service2.IncluirServico(3, "Pedicure", 60, 30);
            Servico service4 = new Servico();
            service2.IncluirServico(4, "Limpeza de pele", 60, 100);

            MinhaBaseDeServicos baseServicos = new MinhaBaseDeServicos();
            baseServicos.IncluirServico(service1);
            baseServicos.IncluirServico(service2);
            baseServicos.IncluirServico(service3);
            baseServicos.IncluirServico(service4);

            return baseServicos;
        }
        static MinhaBaseDeFuncionarios IncluirFuncionarios(MinhaBaseDeServicos baseDeServico)
        {
            Funcionario employee1 = new Funcionario();
            Endereco address1 = new Endereco();
            employee1.IncluirFuncionario("Maria", "123-123", address1, Funcionario.CargoFunc.Cabelereira);
            address1.IncluirAddress(1,"Rua 1", "12345-000", "Bairro 1", "Cidade 1", "Estado 1", "Numero 1", string.Empty);
            
            Funcionario employee2 = new Funcionario();
            Endereco address2 = new Endereco();
            employee2.IncluirFuncionario("Joana", "123-124", address2, Funcionario.CargoFunc.Manicure);
            address2.IncluirAddress(2, "Rua 2", "12345-001", "Bairro 2", "Cidade 2", "Estado 2", "Numero 2", string.Empty);

            Funcionario employee3 = new Funcionario();
            Endereco address3 = new Endereco();
            employee3.IncluirFuncionario("Zefa", "123-125", address3, Funcionario.CargoFunc.Manicure);
            address3.IncluirAddress(3, "Rua 3", "12345-002", "Bairro 3", "Cidade 3", "Estado 3", "Numero 3", string.Empty);

            MinhaBaseDeFuncionarios baseDeFuncionarios = new MinhaBaseDeFuncionarios();
            baseDeFuncionarios.IncluirUmFuncionario(employee1);
            baseDeFuncionarios.IncluirUmFuncionario(employee2);
            baseDeFuncionarios.IncluirUmFuncionario(employee3);

            baseDeFuncionarios.IncluirServicoDeUmFuncionario(1, baseDeServico.Servicos.FirstOrDefault(x => x.IdServico == 1));//retorna o primeiro elemento que satisfazer a condição ou default
            baseDeFuncionarios.IncluirServicoDeUmFuncionario(2, baseDeServico.Servicos.SingleOrDefault(x => x.IdServico == 2));//retorna apenas uma elemento que satisfazer a condição: 
            baseDeFuncionarios.IncluirServicoDeUmFuncionario(3, baseDeServico.Servicos.FirstOrDefault(x => x.IdServico == 3));
            baseDeFuncionarios.IncluirServicoDeUmFuncionario(4, baseDeServico.Servicos.FirstOrDefault(x => x.IdServico == 4));
            

            return baseDeFuncionarios;
        }



//#if DEBUG

//        Console.WriteLine("\r\nTecle enter para fechar...");
//            Console.ReadLine();
//#endif
    }
}


