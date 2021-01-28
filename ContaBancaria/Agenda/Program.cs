
using System;
using System.Collections.Generic;
using System.Text;
using static Manicure.Funcionario;

namespace Manicure
{
    public class Program
    {
        

        public static string NomeCliente { get; set; }

        static void Main(string[] args)
        {
            var meusClientes = IncluirMeusClientes();
            meusClientes.AlterarUmCliente(1, "Elys", "2345-2345", "");
            meusClientes.ExcluirUmCliente(2);

            Funcionario f = new Funcionario();
            f.cargoFuncionario = Funcionario.Especialidades.Cabelereira;


#if DEBUG

            Console.WriteLine("\r\nTecle enter para fechar...");
            Console.ReadLine();
#endif
        }

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


    }
}


