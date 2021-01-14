using System;

namespace Declarando_e_Populando_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            const string aulaIntro = "Introdução às Coleções";
            const string aulaModelando = "Modelando a Classe Aula";
            const string aulaSets = "Trabalhando com Conjuntos";

            //Declarando um array

            string[] aulas = new string[]
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };
        }
    }
}
