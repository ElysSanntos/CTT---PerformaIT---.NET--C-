using System;

namespace Semafaro
{
    class SemaforoArray
    {
        static void Main(string[] args)
        {

            var semafaro = new string[] { "Verde", "Vermelho", "Amarelo" };
            Console.WriteLine(" =========== Podemos atravessar? =========== ");
            Console.WriteLine();
            Console.WriteLine("Digite [1]Verde | [2]Amarelo | [3]Vermelho");
            Console.WriteLine();
            int cor = int.Parse(Console.ReadLine());

            if (cor == 1)
            {
                Console.WriteLine("ABERTO: Pode atravessar com segurança.");
            }
            else if (cor == 2)
            {

                Console.WriteLine("ATENÇÃO: Fique alerta ao atravessar");
            }
            else if (cor == 3)
            {
            
                Console.WriteLine("PARE: O sinal está fechado.");
            }
            
            else 
             
            {
                Console.WriteLine("Avalie sua escolha, o valor informado é Nulo.");

            }

#if DEBUG
            Console.WriteLine(); //pula linha
            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();
#endif


        }
    }
}






  

