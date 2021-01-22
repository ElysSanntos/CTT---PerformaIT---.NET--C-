using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace ParImpar
{
    class ParImparComForeach
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i += 2)
            { Console.WriteLine("Impares: " + i); } 
           

            for (int p = 0; p <= 20; p += 2)

            { 
                Console.WriteLine("Pares: " + p); 
            }



#if DEBUG

            Console.WriteLine("\r\n Tecle enter para fechar...");
            Console.ReadLine();
#endif
        }




    }

    }


