using System;

namespace Semafaro2
{
    class Program
    {
        static void Main(string[] args)
        {
            var semafaro = new string[] { "Verde", "Amarelo", "Vermelho" };
            semafaro[0] = "verde";
            semafaro[1] = "amarelo";
            semafaro[2] = "vermelho";

            Console.WriteLine(" ========= Pronto para atravessar? =======================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Digite Verde | Amarelo | Vermelho");
            Console.WriteLine();
            string cor = Console.ReadLine();


            if (cor == "Verde") {
                Console.WriteLine("ABERTO: Pode atravessar com segurança.");
                if  (cor == "Amarelo")
                    Console.WriteLine("ATENÇÃO: Fique alerta ao atravessar");
                else if (cor == "Vermelho")
                    Console.WriteLine("PARE: O sinal está fechado.");
                else
                {
                    Console.WriteLine("Avalie sua escolha, o valor informado é Nulo.");
                };
            };
#if DEBUG
            Console.WriteLine(); //pula linha
            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();
#endif
        }

            
        }
    }

