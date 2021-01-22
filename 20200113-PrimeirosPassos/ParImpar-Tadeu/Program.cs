
using System;

namespace Listpareimpar
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int par = 2; par <= 20; par = par + 2)
            {
                Console.WriteLine("Números pares: " + par);
            }
            for (int impar = 1; impar <= 20; impar = impar + 2)
            {
                Console.WriteLine("Números Ímpares " + impar);
            }

        }
    }
}
