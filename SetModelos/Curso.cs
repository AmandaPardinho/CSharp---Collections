using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetModelos
{
    public class Curso
    {
        //implementação de um dicionário de alunos
        private Dictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();

        //alunos deve ser um ISet (conjunto) e retornar ReadOnlyCollection
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        
        //propriedade lida pelo código externo => criada de modo a evitar a manipulação fora da classe Curso
        public IList<Aluno> Alunos 
        {
            get
            {
                //método ToList: converte um HashSet em uma lista
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

        private IList<Aula> _aulas;
        private string _nome;
        private string _instrutor;

        public Curso(string nome, string instrutor)
        {
            this._aulas = new List<Aula>();
            this._nome = nome;
            this._instrutor = instrutor;
        }

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(_aulas); }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Instrutor
        {
            get { return _instrutor; }
            set { _instrutor = value; }
        }

        internal void Adiciona(Aula aula)
        {
            this._aulas.Add(aula);
        }

        public int TempoTotal
        {
            get
            {
                return _aulas.Sum(aula => aula.Tempo); 
            }
        }

        public override string ToString()
        {
            return $"Curso: {_nome}\nTempo: {TempoTotal} minutos\nAulas: {string.Join(",", _aulas)}";
        }

        internal void Matricula(Aluno aluno)
        {
            this.alunos.Add(aluno);
            this.dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
        }

        /* em dicionários, os colchetes contém a chave desse dicionário
         */
        public Aluno BuscaMatriculado(int numeroMatricula)
        {
            Aluno aluno = null;

            //out => parâmetro de saída
            this.dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);
            return aluno;
        }

        internal bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        internal void SubstituiAluno(Aluno aluno)
        {
            this.dicionarioAlunos[aluno.NumeroMatricula] = aluno;
        }
    }
}
