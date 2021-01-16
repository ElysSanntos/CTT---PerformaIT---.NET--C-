using System;

namespace _20210116
{
    class Pessoas
    {
        static void Main(string[] args)
        {
            bool cabeloLongo = true;
            bool cabeloCareca = true;
            bool peleNegra = true;
            bool peleMuitoClara = true;
            bool sexoFeminino = true;
            bool corCabeloNegro = true;
            string nome;

            Console.WriteLine(" --- Descubra o nome da pessoa --- ");
            Console.WriteLine();

            Console.WriteLine("Para a cor do cabelo, escolha: [1]Escuros | [2]Coloridos");
            int corCabelo = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Para o tipo de cabelo, escolha: [1]Longos | [2]Careca | [3]Curtos| [4]Médios");
            int tipoCabelo = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Para o sexo, escolha: [1]Feminino | [2]Masculino");
            int sexo = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Para o tom de pele, escolha: [1]Claro | [2]Escuro | [3]MuitoCara");
            int pele = int.Parse(Console.ReadLine());
            Console.WriteLine();



            if (corCabelo==2  && tipoCabelo==1 && sexo== 1 && pele == 1)
            {
                Console.WriteLine(  "Estamos descrevendo a Thaíse: \r\n ");
            } else  if (corCabelo == 1 && tipoCabelo == 1 && sexo == 1 && pele == 3)
                {
                    Console.WriteLine("Estamos descrevendo a Thamires: \r\n ");

                } else if (corCabelo == 1 && tipoCabelo == 2 && sexo == 1 && pele == 1)
            {
                Console.WriteLine("Estamos descrevendo o Tadeu: \r\n ");

            } else if (corCabelo == 2 && tipoCabelo == 4 && sexo == 1 && pele == 2)
            {
                Console.WriteLine("Estamos descrevendo a Gil: \r\n ");
            }
            else
            {
                Console.WriteLine("Pessoa não identificada. Lamento! \r\n ");
            };
#if DEBUG
            Console.WriteLine(); //pula linha
            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();
#endif


        }
    }
}
