using System;
using System.Collections;
using System.Collections.Generic;

namespace Introducao_As_Listas
{
    class DeclarandoLista
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução as Coleções";
            string aulaModelando = "Modelando a classe aula";
            string aulaSets = "Trabalhando com Conjuntos";

            //Declarando uma lista

            List<string> cursos = new List<string>
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };
        }
    }
}
