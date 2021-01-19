using System;
using System.Collections.Generic;

namespace Exercicio_While
{
    class While
    {
        static void Main(string[] args)
        {
            //Declarar a lista
            List<string> nomes = new List<string>();

            //Lendo e armazenando os nomes

            

            while (nomes.Count <=9)
            {
                Console.WriteLine("Digite nomes para inserir na listagem: ");
                nomes.Add(Console.ReadLine());
            }

            //Ordenando a lista em ordem alfabetica e exibindo
            nomes.Sort();
            Console.WriteLine("A lista possui: " + nomes.Count + " nomes ordenados abaixo: ");
            Console.WriteLine();

            //Imprime cada item da lista
            nomes.ForEach(i => Console.WriteLine( " # " + i));


#if DEBUG
            Console.WriteLine(); //pula linha
            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();
#endif
        }

    }


}

