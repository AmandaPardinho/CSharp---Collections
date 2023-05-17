using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoderDosSets
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* sets = conjuntos
             * propriedades:
             * 1 - não permite duplicidade
             * 2 - os elementos não são mantidos em ordem específica
             * diferenças entre conjuntos e listas:
             * 1 - conjuntos permitem uma busca mais rápida de elementos
             * 2 - ao fazer uma busca num conjunto, ele irá utilizar uma Tabela de Espalhamento
             *** a Tabela de Espalhamento ocupa um espaço maior na memória, mas direciona a busca mais rapidamente para a posição que o elemento vai ocupar
             *** na lista é feita a varredura do primeiro ao último elemento para verificar se o elemento buscado existe
             * desempenho HashSet x List:
             * 1 - HashSet possui grande escalabilidade => mantém a performance com uma grande quantidade de elementos
             * 2 - List consome menos memória que um HashSet quando há um grande número de elementos
             */

            //declarando set de alunos => ISet => interface genérica
            ISet<string> alunos = new HashSet<string>();

            //adicionando alunos
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            //imprimir
            Console.WriteLine(alunos);
            Console.WriteLine(string.Join("," , alunos));

            //adicionando mais alunos
            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fábio Gushiken");
            Console.WriteLine(string.Join(",", alunos));

            //determinando a ordem dos alunos após remover e, em seguida, adicionar um aluno
            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");
            Console.WriteLine(string.Join(",", alunos));

            //testando a adição de um aluno pela segunda vez
            alunos.Add("Fábio Gushiken");
            Console.WriteLine(string.Join(",", alunos));

            /* não é possível ordenar um conjunto usando o método Sort
             * para realizar a ordenação, é preciso copiar os elementos do conjunto em uma lista
             */
            List<string> alunosEmLista = new List<string>(alunos);
            alunosEmLista.Sort();
            Console.WriteLine(string.Join(",", alunosEmLista));

            Console.ReadKey();
        }
    }
}