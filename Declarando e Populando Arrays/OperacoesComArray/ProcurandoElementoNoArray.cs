using System;

namespace Declarando_e_Populando_Arrays
{
    class ProcurandoElementosNoArray

    {
        static void Main(string[] args)
        {
            const string aulaIntro = "Introdução às Coleções";
            const string aulaModelando = "Modelando a Classe Aula";
            const string aulaSets = "Trabalhando com Conjuntos";

            //Outra forma de declarar um array

            string[] aulas = new string[3];

            //Populando o array

            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            //Realizar a busca por um item especifico no array, assim que encontra a primeira ocorrencia ele exibe: 
            Console.WriteLine(" ======== Buscando por 'Modelando a Classe Aula' ======== " );
            Console.WriteLine(); //Pula Linha

            Console.WriteLine("A aula: 'Modelando a Classe Aula', está  localizada no indice: " +
                                 Array.IndexOf(aulas, aulaModelando));

            // Para localizar a ultima ocorrencia
            Console.WriteLine(); //pula linha
            Console.WriteLine(" ======== Buscando por última ocorrencia ======== ");
            Console.WriteLine(); //pula linha

            Console.WriteLine("Indice: "+Array.LastIndexOf(aulas, aulaModelando));

            //INVERTENDO as posições do array
            Console.WriteLine();//Pula linha
            Console.WriteLine(" ======== Invertendo os itens nas posições do array ======== ");
            Console.WriteLine();//Pula linha

            Array.Reverse(aulas);
            Impressao(aulas);

            //REVERTENDO as posições do array
            Console.WriteLine();//Pula linha
            Console.WriteLine(" ======== Invertendo os itens nas posições do array ======== ");
            Console.WriteLine();//Pula linha

            Array.Reverse(aulas);
            Impressao(aulas);
            Console.WriteLine();//pula linha

            //Redimensionar o array
            Console.WriteLine(); //pula linha
            Console.WriteLine(" ========= Redimensionando o array para duas posições ========== ");
            Array.Resize(ref aulas, 2);
            Impressao(aulas);
            Console.WriteLine();//pula linha

            //Redimensionar o array
            Console.WriteLine(); //pula linha
            Console.WriteLine(" ========= Redimensionando o array para três posições ========== ");
            Array.Resize(ref aulas, 3);
            Impressao(aulas);
            Console.WriteLine();//pula linha

            aulas[aulas.Length - 1] = "Conclusão";
            Impressao(aulas);

            //Ordenar o array em ordem alfabetica
            Console.WriteLine(); //pula linha
            Console.WriteLine(" ========= Ordenar o Array em ordem alfabetica ========== ");
            Array.Sort(aulas);
            Impressao(aulas);
            Console.WriteLine();//pula linha

            //Realizando cópia dos dois ultimos itens do array
            Console.WriteLine(); //pula linha
            Console.WriteLine(" ========= Criando um novo Array, e copiando os dois ultimos itens. ========== ");
            string [] copia = new string[2];
            //array de destino, indice inicial a partir de onde eu quero copiar,nome do destino,posição inicial do destino,qtd de elementos que quero copiar
            Array.Copy(aulas,1,copia,0,2);
            Impressao(copia);
            Console.WriteLine();//pula linha

            //Clonando um array
            Console.WriteLine(); //pula linha
            Console.WriteLine(" ========= Clonando o Array. ========== ");
            string[] clone = aulas.Clone() as string[];
            Impressao(clone);
            Console.WriteLine();//pula linha

            //Limpando elementos do array
            Console.WriteLine(); //pula linha
            Console.WriteLine(" ========= Limpando elementos do Array. ========== ");
            //o nome do array que quero limpar, indice da posição que quero iniciar a limpeza,quantos indeces quero limpar
            Array.Clear(clone, 1, 2);
            Impressao(clone);
            Console.WriteLine();//pula linha

            //Adicione esse trecho ao final da  Main
#if DEBUG
            Console.WriteLine(); //pula linha
            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();
#endif

            

        }

        private static void Impressao(string[] aulas)
        {
            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);

            }
        }
    }
}
