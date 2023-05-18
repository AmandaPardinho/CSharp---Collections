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

            /* verificando quem é um determinado aluno através da implementação de um novo método
             * apesar de funcionar, realizar a busca desse modo não é a mais eficiente;
             */
            Console.WriteLine("Quem é o aluno com matrícula 5617?");
            Aluno aluno5617 = cSharpColecoes.BuscaMatriculado(5617);
            Console.WriteLine($"aluno5617: {aluno5617}");
            Console.WriteLine("\n");

            /* dicionário => tipo de coleção específica para problemas de busca
             * permite associação de uma chave a um valor (neste caso: chave = matrícula, valor = aluno)
             * quando buscamos uma chave desconhecida no dicionário => erro
             * é necessário tratar o erro para que ele não prejudique a busca do usuário => uso do TryGetValue()
             */
            Console.WriteLine("Quem é o aluno 5618?");
            Console.WriteLine(cSharpColecoes.BuscaMatriculado(5618));
            Console.WriteLine("\n");

            /*tentando adicionar um aluno a uma chave existente =>
             * no dicionário as chaves são únicas e, portanto, não é possível adicionar um novo valor a uma chave cujo valor já foi definido
             * no entanto, é possivel substituir o valor de uma chave já existente
             */
            Aluno fabio = new Aluno("Fábio Gushiken", 5617);
            //cSharpColecoes.Matricula(fabio);
            cSharpColecoes.SubstituiAluno(fabio);
            Console.WriteLine("Quem é o aluno 5617?");
            Console.WriteLine(cSharpColecoes.BuscaMatriculado(5617));
            Console.WriteLine("\n");

            /* modo como um dicionário armazena valores =>
             * faz uso de um código de dispersão ao buscarmos pela chave, assim como um HashSet, que indicará o grupo onde cairá o valor que estamos armazenando.
             * é pelo HashCode da chave (key) do elemento que o dicionário sabe onde posicionar o elemento na memória.
             */

            Console.ReadKey();
        }          
    }
}
