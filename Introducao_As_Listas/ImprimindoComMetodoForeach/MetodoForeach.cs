using System;
using System.Collections;
using System.Collections.Generic;

namespace ImprimindoComMetodoForeach
{
    class MetodoForeach
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

            //Imprimindo a Lista

            Imprimir(aulas);

        }


        private static void Imprimir(List<string> aulas)
        {

            // Metodo Foreach - Para cada aula vai executar o código que está após o operador lambda que está dentro das chaves
            aulas.ForEach(aula =>
            {
                Console.WriteLine(" - " + aula + ";");
            });
            
#if DEBUG
            Console.WriteLine(); //pula linha
            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();
#endif
        }


    }

}