using System;

namespace Declarando_e_Populando_Arrays
{
    class DeclacaoDeArray2
    {
        static void Main(string[] args)
        {
            const string aulaIntro = "Introdução às Coleções";
            const string aulaModelando = "Modelando a Classe Aula";
            const string aulaSets = "Trabalhando com Conjuntos";

            //Outra forma de declarar um array

            string[] aulas = new string[3];

            //Populando o array

            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;


            //Para exibir na tela, preciso primeiro varrer o array:

            //foreach = significa para cada -- para cada aula dentro do aulas, faça.....
            foreach(var aula in aulas)
            {
                Console.WriteLine(aula);

            }

            //Adicione esse trecho ao final da  Main
#if DEBUG
            Console.WriteLine(); //pula linha
            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();
            #endif



        }

    }
}
