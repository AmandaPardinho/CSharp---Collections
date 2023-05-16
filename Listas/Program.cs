using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            /*Listas:
             * contém internamente um array;
             * pode ser chamada também de array dinâmico => se acomoda conforme a quantidade de elementos que tem; 
             */

            //Método 1 para declarar uma lista
            //List<string> aulas = new List<string>
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            //método 2 para declarar uma lista
            List<string> aulas = new List<string>();
            
            //método que adiciona um elemento a uma lista
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            Imprimir(aulas);
            Console.WriteLine("\n");

            //meios para retornar apenas a primeira aula
            Console.WriteLine($"A primeira aula é {aulas[0]}");
            Console.WriteLine($"A primeira aula é {aulas.First()}");
            Console.WriteLine("\n");

            //meios de retornar apenas a última aula
            Console.WriteLine($"A última aula é {aulas[aulas.Count - 1]}");
            Console.WriteLine($"A primeira aula é {aulas.Last()}");
            Console.WriteLine("\n");

            //alterando o nome da aula1
            aulas[0] = "Trabalhando com Listas";
            Imprimir(aulas); 
            Console.WriteLine("\n");

            //mostrando a primeira vez que determinada palavra aparece na lista aulas
            Console.WriteLine($"A primeira aula contendo a palavra 'Trabalhando' é: {aulas.First(aula => aula.Contains("Trabalhando"))}");
            Console.WriteLine("\n");

            //Mostra a última vez que determinada palavra aparece na lista aulas
            Console.WriteLine($"A última aula contendo a palavra 'Trabalhando' é: {aulas.Last(aula => aula.Contains("Trabalhando"))}");
            Console.WriteLine("\n");

            //método FirstOrDefault trata o erro gerado quando não há um determinado elemento na sequência analisada, substituindo o erro por null (não aparece nada)
            Console.WriteLine($"A primeira aula contendo a palavra 'Conclusão' é: {aulas.FirstOrDefault(aula => aula.Contains("Conclusão"))}");
            Console.WriteLine("\n");

            //invertendo a ordem dos elementos da lista
                //se o método for usado uma segunda vez, a lista volta para a ordem inicial
            aulas.Reverse();
            Imprimir(aulas);
            Console.WriteLine("\n");

            //removendo um elemento da lista (no caso, o último)
            aulas.RemoveAt(aulas.Count - 1);
            Imprimir(aulas);
            Console.WriteLine("\n");

            //adicionando um novo elemento a lista
            aulas.Add("Conclusão");
            Imprimir(aulas);
            Console.WriteLine("\n");

            //ordenando a lista em ordem alfabética
            aulas.Sort();
            Imprimir(aulas);
            Console.WriteLine("\n");

            //copiando uma lista => GetRange(posição do primeiro elemento a ser copiado, quantidade de elementos a serem copiados)
                //no exemplo abaixo, a cópia se inicia no penúltimo elemento e pela ele e o último elemento
            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
            Imprimir(copia);
            Console.WriteLine("\n");

            /*clonando uma lista =>
             * listas não possuem um método clone;
             * ao se criar uma nova lista, é possível que ela receba uma collection, ou seja, que ela tenha instanciada uma outra lista
             * quando instanciamos uma collection numa nova lista, a collection é copiada integralmente
             */
            List<string> clone = new List<string>(aulas);
            Imprimir(clone);
            Console.WriteLine("\n");

            //removendo os dois últimos elementos do clone => RemoveRange(posição do primeiro elemento a ser removido, quantidade de elementos a serem removidos)
            clone.RemoveRange(clone.Count - 2, 2);
            Imprimir(clone);
            Console.WriteLine("\n");

            Console.ReadKey();
        }

        private static void Imprimir(List<string> aulas)
        {
            //método 1 para imprimir 
            //foreach (string aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            //método 2 para imprimir
            //count = lenght, só que para listas
            //for (int i = 0; i < aulas.Count; i++)
            //{
            //    Console.WriteLine(aulas[i]);
            //}

            //método 3 para imprimir
            /*método ForEach =>
             * tem por parâmetro uma Action;
             * Action => é um método anônimo;
             * 
             */
            aulas.ForEach(aula => 
            {
                Console.WriteLine(aula);
            });
        }
    }
}
