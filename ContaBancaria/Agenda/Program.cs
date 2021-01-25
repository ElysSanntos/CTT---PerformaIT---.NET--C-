
using System;
using System.Collections.Generic;
using System.Text;


namespace Manicure
{
    public class Program
    {
        public static string NomeCliente { get; set; }

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
            while (continua)
            {
                Console.WriteLine("Escolha :  [1] 15:00 || [2] 16:00 || [3] 17:30");
                cliente.AgendaHorario = int.Parse(Console.ReadLine());

                if (cliente.AgendaHorario == 1)
                {
                    Console.WriteLine("O horario das 15:00, está disponivel, podemos agendar?\r\n " +
                                       "Confirma o horario? [S]SIM || [N]NÃO");

                    string resposta = Console.ReadLine();
                    if (resposta.ToUpper() == "S")
                        Console.WriteLine("Agenda Confirmada para hoje as 15:hrs, lhe aguardamos, "
                                        + cliente.NomeCliente + ". Agradecemos seu contato!");
                    //Preciso encerrar a aplicação aqui
                    Console.WriteLine("\r\n [S]Sair || [N]Continuar");
                    string sair = Console.ReadLine();
                     if(sair.ToUpper()=="S")
                    continua = false;

                }

                else if (cliente.AgendaHorario == 2)
                {
                    Console.WriteLine("O horario das 16:00, está disponivel, podemos agendar?\r\n " +
                               "Confirma o horario? [S]SIM || [N]NÃO");

                    string resposta = Console.ReadLine();
                    if (resposta.ToUpper() == "S")
                        Console.WriteLine("Agenda Confirmada para hoje as 15:hrs, lhe aguardamos, "
                                        + cliente.NomeCliente + ". Agradecemos seu contato!");
                    Console.WriteLine("\r\n [S]Sair || [N]Continuar");
                    string sair = Console.ReadLine();
                    if (sair.ToUpper() == "S")
                        continua = false;

                }
                else if (cliente.AgendaHorario == 3)
                {
                    Console.WriteLine("O horario das 17:30, está disponivel, podemos agendar?\r\n " +
                               "Confirma o horario? [S]SIM || [N]NÃO");

                    string resposta = Console.ReadLine();
                    if (resposta.ToUpper() == "S")
                        Console.WriteLine("Agenda Confirmada para hoje as 15:hrs, lhe aguardamos, "
                                        + cliente.NomeCliente + ". Agradecemos seu contato!");
                    Console.WriteLine("\r\n [S]Sair || [N]Continuar");
                    string sair = Console.ReadLine();
                    if (sair.ToUpper() == "S")
                        continua = false;
                }
                else
                {
                    Console.WriteLine("Horario informado é inválido ou está indisponivel, tente novamente, " +
                        "por favor.");
                    continua = false;
                }
            }

#if DEBUG

            Console.WriteLine("\r\nTecle enter para fechar...");
            Console.ReadLine();
#endif

        }
    }
}

