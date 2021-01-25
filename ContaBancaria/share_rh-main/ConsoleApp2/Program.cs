using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Jujuba";

            Console.WriteLine("Olá " + cliente.Nome);
            bool continua = true;
            while (continua)
            {
                Console.WriteLine("Qual conta vc quer movimentar? C - Corrente ou P - Poupança");
                string conta = Console.ReadLine();

                Console.WriteLine("O que vc deseja fazer? D - Depósito ou S - Saque");
                string resposta = Console.ReadLine();


                if (resposta.ToUpper() == "D")
                {
                    Console.WriteLine("Qual o valor para Depósito?");
                    int valorParaDeposito = Convert.ToInt32(Console.ReadLine());
                    string retorno;

                    if (conta.ToUpper() == "C")
                    {
                        retorno = cliente.ContaCorrente.Depositar(valorParaDeposito);
                    }
                    else
                    {
                        retorno = cliente.ContaPoupanca.Depositar(valorParaDeposito);
                    }
                    Console.WriteLine(retorno);
                }
                else if (resposta.ToUpper() == "S")
                {
                    Console.WriteLine("Qual o valor para Saque?");
                    int valorParaSaque = Convert.ToInt32(Console.ReadLine());
                    string retorno;

                    if (conta.ToUpper() == "C")
                    {
                        retorno = cliente.ContaCorrente.Sacar(valorParaSaque);
                    }
                    else
                    {
                        retorno = cliente.ContaPoupanca.Sacar(valorParaSaque);
                    }
                    Console.WriteLine(retorno);
                }
                else
                    Console.WriteLine("Opção inválida");

                Console.WriteLine("Sair: S/N");
                continua = Console.ReadLine() != "S";
            }
        }
    }
}