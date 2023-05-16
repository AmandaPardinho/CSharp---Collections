using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var aulaIntro = new Aula("Introdução às Coleções", 20);
            var aulaModelando = new Aula("Modelando a Classe Aula", 18);
            var aulaSets = new Aula("Trabalhando com Conjuntos", 16);

            //criação da lista 'aula'
            List<Aula> aulas = new List<Aula>();

            //adição dos elementos da lista aula
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);
            //aulas.Add("Conclusão");

            Imprimir(aulas);
            
            /*ordenando a lista por ordem alfabética=> 
             * para que uma lista possa ser ordenada (método Sort), é necessário que a classe que dá origem ao objeto implemente a interface IComparable;
             * ao implementá-la, será necessário implementar seus métodos, ou seja, implementar o método CompareTo
             * feito isso, basta determinar qual será o retorno do método CompareTo e rodar novamente a aplicação
             */
            aulas.Sort();
            Imprimir(aulas);

            /*ordenando a lista por duração da aula =>
             * uso de uma expressão lambda que recebe dois parâmetros, um inicial e outro final;
             * após o operador lambda ( => ), será encontrada a comparação entre os dois parâmetros (inicial, final), usando o método CompareTo
             */
            aulas.Sort((tempo1, tempo2) => tempo1.Tempo.CompareTo(tempo2.Tempo));

            Console.ReadKey();
        }

        private static void Imprimir(List<Aula> aulas)
        {
            Console.Clear();

            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }

    //criação da classe aula
    class Aula: IComparable
    {
        private string titulo;
        private int tempo;

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Tempo { get => tempo; set => tempo = value; }

        public int CompareTo(object? obj)
        {
            Aula that = obj as Aula;
            return this.titulo.CompareTo(that.titulo);
        }

        public override string ToString()
        {
            //interpolação de strings
            return $"[Título: {titulo}; Duração: {tempo} minutos]";
        }
    }
}
