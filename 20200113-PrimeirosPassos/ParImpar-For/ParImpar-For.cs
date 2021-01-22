using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace ParImpar
{
    class ParImparComFor

    {
        static void Main(string[] args)
        {
            int[] num = new int[20];

            int par ;
            int impar = 0;
            Console.WriteLine("Par ou Impar? \n");

            //percorrendo o array
            for (int i = 0; i < num.Length; i++)
                if (num[i] % 2 == 0)
                {
                    par = num[1];
                    Console.WriteLine(num[1]);
                }


#if DEBUG

            Console.WriteLine("\r\n Tecle Enter para fechar...");
            Console.ReadLine();
#endif
        }
    }


        }


