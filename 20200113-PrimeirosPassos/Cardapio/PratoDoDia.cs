using System;
using System.Collections.Generic;

namespace Cardapio
{
    class PratoDoDia
    {
        static void Main(string[] args)
        {
            List<string> cardapioSemanal = new List<string>();
            int diaSemana;

                Console.WriteLine(" === Escolha o dia semana que deseja visualizar o cardápio === \r\n");
                Console.WriteLine("[1]Segunda-Feira | [2]Terça-Feira | [3]Quarta-Feira |\r\n [4]Quinta-Feira | [5]Sexta-Feira | [6]Sábado | [7]Domingo\r\n");
                if (!int.TryParse(Console.ReadLine(), out diaSemana))
            {
                Console.WriteLine("Valor digitado, é inválido");
            }
            else 
            {
                //chamar método
                cardapio(diaSemana);
            }
            //Declarando o método:

            static void cardapio(int diaSemana)

            {

                switch (diaSemana)
                {
                    case 1:
                        Console.WriteLine("\r - Arroz/Feijão\r\n " +
                            " - Pernil em cubos\r\n " +
                            "- Farofa de cenoura\r\n " +
                            "- Salada de Couve");
                        break;
                    case 2:
                        Console.WriteLine("\r - Arroz/Feijão\r\n" +
                            " - Carne de boi com mandioca\r\n " +
                            "- Abobrinha com cheiro Verde\r\n " +
                            "- Salada de Acelga com Rúcula");
                        break;
                    case 3:
                        Console.WriteLine("\r - Arroz/Feijão\r\n" +
                            " - Linguiça de Pernil Assada\r\n " +
                            "- Abobora Moranga\r\n " +
                            "- Salada de Acelga");
                        break;
                    case 4:
                        Console.WriteLine("\r - Arroz/Feijão\r\n" +
                            " - Frango Assado\r\n " +
                            "- Macarrão de Alho e óleo\r\n " +
                            "- Salada de Almeirão");
                        break;
                    case 5:
                        Console.WriteLine("\r - Arroz\r\n" +
                            " - Feijoada\r\n " +
                            "- Farofa Dourada\r\n " +
                            "- Salada de Couve");
                        break;
                    case 6:
                        Console.WriteLine("\r - Arroz/Feijão\r\n" +
                            " - Filé de Tilápia\r\n " +
                            "- Molho Tártaro \r\n " +
                            "- Salada de Alface com tomate");
                        break;
                    case 7:
                        Console.WriteLine("\r\n - Lasanha de quatro queijos\r\n"+
                            " - Costelinha com mandioca\r\n " +
                            "- Couve-flor gratinada\r\n " +
                            "- Salada de macarrão com Atum");
                        break;

                }

#if DEBUG
                Console.WriteLine(); //pula linha
                Console.WriteLine("Tecle enter para fechar...");
                Console.ReadLine();
#endif



            }



        }
    }
}
