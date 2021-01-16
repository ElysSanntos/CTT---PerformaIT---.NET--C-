using System;
using System.Collections.Generic;

namespace AdicionandoElementos_A_Lista
{
    class AddElementos
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

            // foreach vai varrer todos os elementos da lista
            foreach (var aula in aulas)
            {
                //Pegar cada um dos elementos encontrados e exibir na console
                Console.WriteLine(" - " + aula + ";");
            }
#if DEBUG
            Console.WriteLine(); //pula linha
            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();
#endif
        }


    }

}