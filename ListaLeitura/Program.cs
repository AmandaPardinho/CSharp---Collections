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

            /*code smell => chamado de exposição indecente (neste caso)
             * a classe Curso não tem nenhum controle sobre as suas aulas, sobre sua lista de aulas; a lista esta exposta;
             * o correto seria desenvolver um método na classe Curso de modo que a adição de um novo curso fosse feita por lá;
             * necessidade de encapsular a lista
             */
            /*cSharpColecoes.Aulas.Add(new Aula("Trabalhando com Listas", 21));
             * devido à proteção (encapsulamento) da lista na classe Curso, não é possível adicionar um elemento (impossibilidade de modificação)
             */

            cSharpColecoes.Adiciona(new Aula("Trabalhando com listas", 21));
            Imprimir(cSharpColecoes.Aulas);

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
