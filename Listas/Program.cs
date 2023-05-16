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
             * 
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
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            Imprimir(aulas);
            Console.WriteLine("\n");
            Console.WriteLine($"A primeira aula é {aulas[0]}");
            Console.WriteLine($"A primeira aula é {aulas.First()}");
            Console.WriteLine("\n");
            Console.WriteLine($"A última aula é {aulas[aulas.Count - 1]}");
            Console.WriteLine($"A primeira aula é {aulas.Last()}");
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
