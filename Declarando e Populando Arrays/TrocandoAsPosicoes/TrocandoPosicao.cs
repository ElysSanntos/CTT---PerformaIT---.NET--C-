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


            //Trocando os itens de lugar

            aulas[0] = aulaSets;
            aulas[2] = aulaIntro;

            Impressao(aulas);


            //Adicione esse trecho ao final da  Main
#if DEBUG
            Console.WriteLine(); //pula linha
            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();
#endif



        }

        private static void Impressao(string[] aulas)
        {
            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);

            }
        }
    }
}
