using System;
using System.Collections.Generic;

namespace _20200113_Lista

{
    class Lista
    {
        static void Main(string[] args)
        {
            List<int> minhaLista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int indice = minhaLista.Count - 2;
            Console.WriteLine("Informa o tamanho da lista: " + minhaLista.Count + " posições");
            Console.WriteLine("Informa o dado na posição/índice informada: " + minhaLista[indice]);
        }
    }
}
