using System;
using System.Collections.Generic;
using System.Collections;

namespace _20210119_MeninoOuMenina
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> meninoOuMenina = new List<string> { "Renata", "Tadeu", "Alexandre","Thaise", "Thamirys",
                                                            "Matheus","Mariana","Valeska"};

            int menino = 0;
            int menina = 0;

            foreach(var nome in meninoOuMenina) { 

            
            Console.WriteLine("O nome: "+ nome + " é de menino[1] ou de Menina[2]? ");

                String sexo = Console.ReadLine();
                if (sexo.ToLower() == "2")
                    menina += 1;
                else if (sexo.ToLower() == "1")
                    menino++;
                else
                    Console.WriteLine("Escolha: [1] para menino ou [2] para menina");
            }
        Console.WriteLine("Encontramos na listagem: "+ menina + " meninas, e " + menino + " meninos.");

#if DEBUG
            Console.WriteLine(); //pula linha
            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();
#endif

        }



    }


}
