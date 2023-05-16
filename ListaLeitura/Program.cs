using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLeitura
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso cSharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");

            /*code smell (relativo ao método comentado abaixo) => chamado de exposição indecente (neste caso)
             * a classe Curso não tem nenhum controle sobre as suas aulas, sobre sua lista de aulas; a lista esta exposta;
             * o correto seria desenvolver um método na classe Curso de modo que a adição de um novo curso fosse feita por lá;
             * necessidade de encapsular a lista
             */
            /*cSharpColecoes.Aulas.Add(new Aula("Trabalhando com Listas", 21));
             * devido à proteção (encapsulamento) da lista na classe Curso, não é possível adicionar um elemento (impossibilidade de modificação)
             */

            //adição de aula após proteger a classe Curso
            cSharpColecoes.Adiciona(new Aula("Trabalhando com listas", 21));
            Imprimir(cSharpColecoes.Aulas);

            //adicionando mais duas aulas
            cSharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            cSharpColecoes.Adiciona(new Aula("Modelando com Coleções", 19));
            Imprimir(cSharpColecoes.Aulas);

            /*ordenar a lista de aulas =>
             * não é possível ordenar uma lista implementada com a interface IList com o método Sort (a IList não dá suporte para o método Sort);
             * é preciso usar um outro método para ordená-la
             */
            //cSharpColecoes.Aulas.Sort();

            /*criando uma copia da lista IList para uma outra lista List=>
             * a lista copiada é uma lista já populada composta pela lista implementada pelo IList
             * assim, a nova lista, que não é mais só de leitura, permite que as manipulações com os métodos da classe List sejam feitas e, portanto, podemos novamente usar o método Sort
             */
            List<Aula> aulasCopiadas = new List<Aula>(cSharpColecoes.Aulas);
            

            //ordenando a lista List (cópia)
            aulasCopiadas.Sort();
            Imprimir(aulasCopiadas);
            Console.WriteLine("\n");

            //calculando o tempo total de curso
            Console.WriteLine(cSharpColecoes.TempoTotal);
            Console.WriteLine("\n");

            //imprimir todos os detalhes do curso
            Console.WriteLine(cSharpColecoes);

            Console.ReadKey();
        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
