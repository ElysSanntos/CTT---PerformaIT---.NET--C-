using System;
using System.Collections.Generic;

namespace AprendendoSwitchCase
{
    class CriarMetodo
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            {

                Console.WriteLine("Informe a sua Idade:");
                int idade = -1;
                // Verifica se a informação que o user inputou é verdadeira
                if (!int.TryParse(Console.ReadLine(), out idade))
                    Console.WriteLine("Idade informada está inválida.");
                else

                {
                    VerificacaoPorSwitch(idade);
                    VerificacaoPorFor(idade);
                }


                static void VerificacaoPorSwitch(int idade)
                {
                    switch (idade)
                    {
                        case 0:
                            Console.WriteLine("É Bebezinho");
                            break;
                        case int i when (i >= 1 && i <= 8):
                            Console.WriteLine("É Criança");
                            break;
                        case int i when (i >= 9 && i <= 12):
                            Console.WriteLine("É pré - adolescente");
                            break;
                        case int i when (i >= 3 && i <= 17):
                            Console.WriteLine("É adolescente");
                            break;
                        default:
                            Console.WriteLine("É adulto");
                            break;

                    }
                }

                static void VerificacaoPorFor(int idade)
                {
                    if (idade < 0)
                        Console.WriteLine("Idade inválida");
                    else if (idade == 0)
                        Console.WriteLine("É Bebezinho");
                    else if (idade >= 1 && idade <= 8) 
                    Console.WriteLine("É Criança");
                    else if (idade >= 9 && idade <= 12)
                        Console.WriteLine("É pré - adolescente");
                    else
                    {
                        Console.WriteLine("É adulto");
                    }
                }


            }
#if DEBUG
            Console.WriteLine(); //pula linha
            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();
#endif
        }
    }
}
