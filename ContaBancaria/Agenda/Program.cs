
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static Manicure.Funcionario;

namespace Manicure
{
    public class Program
    {
        

        public static string NomeCliente { get; set; }

        static void Main(string[] args)
        {
            //Chamando os metodos aqui
            var meusClientes = IncluirMeusClientes();
            var meusServicos = IncluirMeusServicos();
            var meusFuncionarios = IncluirFuncionarios(meusServicos);

            meusClientes.AlterarUmCliente(1, "Elys", "2345-2345", "");
            meusClientes.ExcluirUmCliente(2);
            

        }
        Funcionario funcionario = new Funcionario();
       
       

        static MinhaBaseDeClientes IncluirMeusClientes()
            {
                Cliente c1 = new Cliente();
                c1.Incluir(1, "Thamirys", "3456-3456", "");
                Cliente c2 = new Cliente();
                c2.Incluir(2, "Thaise", "4567-4567", "");

                MinhaBaseDeClientes mc = new MinhaBaseDeClientes();
                mc.Incluir(c1);
                mc.Incluir(c2);

                var c3 = new Cliente();
                c3.Incluir(3, "Maria", "5678-5678", "");
                var c4 = new Cliente();
                c4.Incluir(4, "Joana", "6789-6789", "");

                mc.IncluirLista(c3, c4);

                return mc;

            }
        static MinhaBaseDeServicos IncluirMeusServicos()
        {
            Servico service1 = new Servico();
            service1.Incluir(1,"Corte de Cabelos", 60, 120);
            Servico service2 = new Servico();
            service2.Incluir(2,"Manicure", 60, 20);
            Servico service3 = new Servico();
            service2.Incluir(3, "Pedicure", 60, 30);
            Servico service4 = new Servico();
            service2.Incluir(4, "Limpeza de pele", 60, 100);

            MinhaBaseDeServicos baseServicos = new MinhaBaseDeServicos();
            baseServicos.Incluir(service1);
            baseServicos.Incluir(service2);
            baseServicos.Incluir(service3);
            baseServicos.Incluir(service4);

            return baseServicos;
        }
        static MinhaBaseDeFuncionarios IncluirFuncionarios(MinhaBaseDeServicos baseDeServico)
        {
            Funcionario employee1 = new Funcionario();
            Endereco address1 = new Endereco();
            employee1.Incluir(1, "Maria", "123-123", address1, Funcionario.CargoFunc.Cabelereira);
            address1.Incluir(1, "Rua 1", "12345-000", "Bairro 1", "Cidade 1", "Estado 1", "Numero 1", string.Empty);
            
            Funcionario employee2 = new Funcionario();
            Endereco address2 = new Endereco();
            employee2.Incluir(2, "Joana", "123-124", address2, Funcionario.CargoFunc.Manicure);
            address2.Incluir(2, "Rua 2", "12345-001", "Bairro 2", "Cidade 2", "Estado 2", "Numero 2", string.Empty);

            Funcionario employee3 = new Funcionario();
            Endereco address3 = new Endereco();
            employee3.Incluir(3, "Zefa", "123-125", address3, Funcionario.CargoFunc.Manicure);
            address3.Incluir(3, "Rua 3", "12345-002", "Bairro 3", "Cidade 3", "Estado 3", "Numero 3", string.Empty);

            MinhaBaseDeFuncionarios baseDeFuncionarios = new MinhaBaseDeFuncionarios();
            baseDeFuncionarios.Incluir(employee1);
            baseDeFuncionarios.Incluir(employee2);
            baseDeFuncionarios.Incluir(employee3);

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


