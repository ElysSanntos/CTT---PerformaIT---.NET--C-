using System;
using System.Collections;
using System.Collections.Generic;

namespace Introducao_As_Listas
{
    class ImprimirListaComFor
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução as Coleções";
            string aulaModelando = "Modelando a classe aula";
            string aulaSets = "Trabalhando com Conjuntos";

            //Declarando uma lista

            List<string> aulas = new List<string>
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };

            //Imprimindo a Lista

             Imprimir(aulas);

        }


        private static void Imprimir(List<string> aulas)
        {

            // varrer todos os elementos da lista com o laço For
            for(int i = 0;i < aulas.Count; i++)
            {
                Console.WriteLine(aulas[i]);
            }
#if DEBUG
            Console.WriteLine(); //pula linha
            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();
#endif
        }


    }

}

