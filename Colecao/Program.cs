using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com conjuntos";

            //Declarando o array - método 1
            //string[] aulas = new string[]
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            //Declarando o array - método 2
            string[] aulas = new string[3];
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            Imprimir(aulas);
            Console.WriteLine("");
            Console.WriteLine(aulas[0]);
            Console.WriteLine("");
            Console.WriteLine(aulas.Length - 1);
            Console.WriteLine("\n");
            
            //Retorna o índice da primeira aparição de um determinado elemento
            Console.WriteLine($"Aula modelando está no índice {Array.IndexOf(aulas, aulaModelando)}");
            Console.WriteLine("\n");

            //Retorna o índice da última aparição de um determinado parâmetro
            Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));
            Console.WriteLine("\n");

            //Revertendo a ordem do array
                //Caso seja feito uma segunda reversão usando o método Reverse, o array volta com a ordem inicial
            Array.Reverse(aulas);
            Imprimir(aulas);
            Console.WriteLine("\n");

            //Redimencionando o array => método resize faz uma cópia interna do array e, depois, passa a apontar para o local que essa cópia está alocada
            Array.Resize(ref aulas, 2);
            Imprimir (aulas);
            Console.WriteLine("\n");
            Array.Resize(ref aulas, 3);
            Imprimir(aulas);
            Console.WriteLine("\n");
            aulas[aulas.Length - 1] = "Conclusão";
            Imprimir(aulas);
            Console.WriteLine("\n");

            //Ordenando o array em ordem alfabética
                //Uma vez que se usa o método Sort, não é mais possível voltar ao estado inicial
            Array.Sort(aulas);
            Imprimir(aulas);
            Console.WriteLine("\n");

            //Copiando um array
                //Array.Copy(nome do array, posição de início da cópia, nome do novo array, posição de início do novo array, quantidade de elementos a serem copiados)
            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2);
            Imprimir(copia);

            Console.ReadKey();
        }

        private static void Imprimir(string[] aulas)
        {
            //Imprimindo os componentes do array - método 1
            //foreach (string aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            //Imprimindo os componentes do array - método 2
            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }
    }
}