
using System;
using System.Collections.Generic;
using System.Text;


namespace Manicure
{
    public class Program
    {
        public static string NomeCliente { get;  set; }

        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.CodCliente = 01;
            cliente.NomeCliente = "Maria Jose";
            cliente.TelefoneCliente = "1234-1234";

            Profissional profissional = new Profissional();
            profissional.codProfissional = 01;
            profissional.especialidade = "Manicure";
            profissional.nomeProfissional = "Leila";

            Cliente horaAgenda = new Cliente();



            Console.WriteLine("Olá " + cliente.NomeCliente + ". \r\nVamos agendar um horario para hoje? \r\n");
            bool continua = true;

            //Confirmar se a cliente deseja agendar um horario:
            while (continua) {
                Console.WriteLine("Escolha :  [1] 15:00 || [2] 16:00 || [3] 17:30");
                cliente.AgendaHorario = int.Parse(Console.ReadLine());


                switch (cliente.AgendaHorario)
                {

                    case 1:
                        //Console.WriteLine("O horario das 15:00, está disponivel, podemos agendar?");
                        break;

                    case 2:
                        Console.WriteLine("O horario das 16:00, está disponivel, podemos agendar?");
                        break;

                    case 3:
                        Console.WriteLine("O horario das 17:30, está disponivel, podemos agendar?");
                        break;

                    default:
                        Console.WriteLine("Horario informado é inválido ou está indisponivel, tente novamente, por favor.");
                        break;

                }

                if(cliente.AgendaHorario ==1 || cliente.AgendaHorario == 2 || cliente.AgendaHorario == 3)
                {
                    Console.WriteLine(" O Horario " + cliente.AgendaHorario+" foi agendado com sucesso, lhe aguardamos! ");
                }
                else
                {
                    Console.WriteLine("Por favor, verifique o horario digitado");
                    Console.WriteLine("Sair: S/N");
                    continua = Console.ReadLine() != "S";
                }
            }


            

            

#if DEBUG
           
            Console.WriteLine("\r\nTecle enter para fechar...");
            Console.ReadLine();
#endif

        }



    }
}
