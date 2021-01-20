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


            List<int> parImpar = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,
                                                14, 15, 16, 17, 18, 19, 20 };


            Console.WriteLine("Par ou Impar? \n");

            int p = 0;
            int i = 0;

            //Percorrendo os numeros da lista
            foreach (var par in parImpar)

                if (parImpar[i] % 2 == 0)
                    parImpar.AddRange(Convert.ToInt32(parImpar[i]), out 0);
            Console.WriteLine(p);

            //foreach (var impar in parImpar)

            //    if ((int)impar % 2 != 0) parImpar.Add(i);
            //Console.WriteLine("Quantidade: {0}", parImpar.Count);


#if DEBUG
            Console.WriteLine(); //pula linha
            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();
#endif
        }

    }

}
