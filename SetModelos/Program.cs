using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetModelos
{
    public class Program
    {
        static void Main(string[] args)
        {
            //declarando o curso
            Curso cSharpColecoes = new Curso("C# Coleções", "Marcelo Oliveira");

            //Adicionando aulas ao curso
            cSharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            cSharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            cSharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

            //instanciando alunos e suas matrículas
            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            //matriculando os alunos nos cursos
            cSharpColecoes.Matricula(a1);
            cSharpColecoes.Matricula(a2);
            cSharpColecoes.Matricula(a3);

            //imprimindo os alunos matriculados
            Console.WriteLine("Imprimindo os alunos matriculados");
            foreach (var aluno in cSharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n");

            //verificando se um dado aluno está matriculado ou não
            Console.WriteLine($"O aluno a1 {a1.Nome} está matriculado?");
            Console.WriteLine(cSharpColecoes.EstaMatriculado(a1));
            Console.WriteLine("\n");

            //instanciando novo aluno com nome Vanessa Tonini e verificando a matrícula
            Aluno tonini = new Aluno("Vanessa Tonini", 34672);
            Console.WriteLine($"Tonini está matriculada? {cSharpColecoes.EstaMatriculado(tonini)}");
            Console.WriteLine("\n");

            //a1 == tonini?
            Console.WriteLine($"a1 == tonini? {a1 == tonini}");
            Console.WriteLine("\n");

            //equals
            Console.WriteLine($"a1.equals é igual a tonini? {a1.Equals(tonini)}");
            Console.WriteLine("\n");

            Console.ReadKey();
        }          
    }
}
