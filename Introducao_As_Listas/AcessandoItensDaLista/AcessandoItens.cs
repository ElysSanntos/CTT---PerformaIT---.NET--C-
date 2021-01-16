using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AcessandoItensDaLista
{
    class AcessandoItens
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução as Coleções";
            string aulaModelando = "Modelando a classe aula";
            string aulaSets = "Trabalhando com Conjuntos";

            //Declarando uma lista sem definir os elementos iniciais

            List<string> aulas = new List<string>();

            // Adicionando os elementos a lista

            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            //Imprimindo itens acessados

           
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" --- Exibindo a primeira aula com a posição da Lista. --- ");
            Console.WriteLine();
            Console.WriteLine("A primeira aula da lista é: " + aulas[0] + ";");
            Console.WriteLine();

            Console.WriteLine(" --- Exibindo a primeira aula com o método First(). --- ");
            Console.WriteLine();
            Console.WriteLine("A primeira aula da lista é: " + aulas.First() + ";");
            Console.WriteLine();

            Console.WriteLine(" --- Exibindo a última aula com Count - 1. --- ");
            Console.WriteLine();
            Console.WriteLine("A última aula da lista é: "  + aulas[aulas.Count - 1] +  ";");
            Console.WriteLine();

            Console.WriteLine(" --- Exibindo a última aula com o método Last(). --- ");
            Console.WriteLine();
            Console.WriteLine("A última aula da lista é: "  + aulas.Last() + ";");
            Console.ReadLine();

#if DEBUG
            Console.WriteLine(); //pula linha
            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();
#endif

        }


       


    }

}
