using System;
using System.Collections.Generic;

namespace _20210114_Exercicios
{
    class LerArmazenarExibirListaDeNomes
    {
        static void Main(string[] args)
        {

            //Declarando listas genéricas
            List<string> nomes = new List<string>();
            
            //Lendo e armazenando os nomes
            Console.WriteLine("Digite 1º nome para inserir na lista: ");
            nomes.Add(Console.ReadLine());
            Console.WriteLine("Digite o 2º nome para inserir na lista: ");
            nomes.Add(Console.ReadLine());
            Console.WriteLine("Digite o 3º nome para inserir na lista: ");
            nomes.Add(Console.ReadLine());
            Console.WriteLine("Digite o 4º nome para inserir na lista: ");
            nomes.Add(Console.ReadLine());
            Console.WriteLine("Digite o 5º nome para inserir na lista: ");
            nomes.Add(Console.ReadLine());

            //Ordena a lista
            nomes.Sort();
            Console.WriteLine("A lista possui: " + nomes.Count + " nomes: ");
            Console.WriteLine();

            //Imprime cada item da lista
            nomes.ForEach(i => Console.WriteLine(i));
            
        }
    }
}
