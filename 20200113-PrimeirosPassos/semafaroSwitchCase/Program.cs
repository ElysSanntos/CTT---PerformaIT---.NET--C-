using System;

namespace semafaroSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string cor;
            char escolha;

            Console.WriteLine("============= Para atravessar a rua, verifique o semafaro =============");
            Console.WriteLine();
            Console.WriteLine("Escolha a cor do semafaro: [1]Verde | [2]Amarelo | [3]Vermelho |");
            escolha = char.Parse(Console.ReadLine());

                switch (escolha)
            {
                case '1':
                    cor = "Verde";
                    break;
                case '2':
                    cor = "Amarelo";
                    break;
                case '3':
                    cor = "Vermelho";
                    break;
                default:
                    cor = "Nulo";
                    break;

            }
            if(cor == "Verde")
            {
                Console.WriteLine("ABERTO: Pode atravessar com segurança.");
         
            if(cor == "Amarelo")
         
                Console.WriteLine("ATENÇÃO: Fique alerta ao atravessar");
          
            if(cor == "Vermelho")
           
                Console.WriteLine("PARE: O sinal está fechado.");
            }
            else
            if(cor =="Nulo")
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
