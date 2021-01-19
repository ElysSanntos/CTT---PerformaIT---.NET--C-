using System;

namespace Enquanto_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            while(soma != 10)
            {
                Console.WriteLine("Quanto é 5 + 5 ?");
                int.TryParse(Console.ReadLine(), out soma);
            }
            Console.WriteLine("Resposta correta!");
#if DEBUG
            Console.WriteLine(); //pula linha
            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();
#endif
        }

    }

}
