using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            //crando uma lista de frutas
            List<string> frutas = new List<string>
            {
                "abacate", "banana", "caqui", "damasco", "figo"
            };

            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }
            Console.WriteLine("\n");

            /* em uma lista, quando inserimos um elemento novo, ele entra na posição final do seu array interno
             * no entanto, caso seja necessário inserir este elemento no meio da lista, todos os elementos que vierem depois da posição em que ele foi inserido terão que se deslocar uma posição (posição + 1)
             * o mesmo acontece caso um elemento seja removido: todos os elementos que se encontravam depois dele são deslocados uma posição (posição - 1) para que, assim, não sobre um buraco no meio da lista
             * todo esse deslocamento demanda um esforço computacional maior do programa, piorando o desempenho quanto maior for a lista
             * assim, para evitar este tipo de problema, há uma coleção mais apropriada para inserir ou remover rapidamente um elemento: a LINKEDLIST
             * linkedlist =>
             * os elementos não precisam estar em sequência na memória
             * cada elemento sabe quem é o elemento anterior e quem é o próximo elemento => cada elemento é um nó (LinkedListNode) que contém um valor e cada nó se liga a outro nó por ponteiros (manutenção da ordem)
             * cada linkedlistnode encapsula um tipo primitivo => isso é necessário pois tais tipos não contém informações de ponteiros
             * além disso, a linkedlist não dá suporte ao acesso de índice e, por isso, não é possível usar o laço for
             * para exibir os valores de uma linkedlist é necessário usar um foreach
             */

            //instanciando uma linkedlist de dias da semana
            LinkedList<string> dias = new LinkedList<string>();

            //adicionando um dia qualquer à lista
            var d4 = dias.AddFirst("quarta");

            //retornando o valor de um nó
            Console.WriteLine($"d4 = {d4.Value}");

            //existem quatro formas de adicionar um elemento a uma linkedlist
            var d2 = dias.AddBefore(d4, "segunda");
            var d3 = dias.AddAfter(d2, "terça");
            var d6 = dias.AddAfter(d4, "sexta");
            var d7 = dias.AddLast("sábado");
            var d5 = dias.AddBefore(d6, "quinta");
            var d1 = dias.AddBefore(d2, "domingo");

            //imprimir os elementos da lista
            foreach (string dia in dias)
            {
                Console.WriteLine(dia);
            }
            Console.WriteLine("\n");

            /* encontrar os elementos da lista => uso do método Find
             * o método Find não é eficiente para fazer muitas buscas => caso isso seja necessário, é preciso usar uma outra coleção que não seja uma linkedlist
             */
            var quarta = dias.Find("quarta");

            //existem duas formas de remover um elemento na linkedlist => pelo valor dele ou referenciando o linkedlistnode 
            dias.Remove("quarta");
            foreach (string dia in dias)
            {
                Console.WriteLine(dia);
            }


            Console.ReadKey();
        }
    }
}
