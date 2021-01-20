using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> lista = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Introduza um numero");

            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) lista.Add(num);
        }

        Console.WriteLine("Quantidade: {0}", lista.Count);

        for (int i = 0, length = lista.Count; i < length; i++)
        {
            Console.WriteLine("item: {0}, value: {1}", i, lista[i]);
        }
    }
}  }
}
