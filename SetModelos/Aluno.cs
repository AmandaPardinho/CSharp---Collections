using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetModelos
{
    public class Aluno
    {
		private string _nome;
		private int _numeroMatricula;

        public Aluno(string nome, int numeroMatricula)
        {
            this._nome = nome;
            this._numeroMatricula = numeroMatricula;
        }

        public string Nome
		{
			get { return _nome; }
			set { _nome = value; }
		}

		public int NumeroMatricula
		{
			get { return _numeroMatricula; }
			set { _numeroMatricula = value; }
		}

        public override string ToString()
        {
            return $"[Nome: {_nome}; Matrícula: {_numeroMatricula}]";
        }

        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;
            if (outro == null)
            {
                return false;
            }
            return this._nome.Equals(outro._nome);
        }

        /* GetHashCode =>
         * é um código de dispersão/espalhamento
         * cada elemento do conjunto é formado por um código e cada código cai numa tabela de dispersão que determina qual local da memória o elemento vai cair
         * quanto mais diversos esses locais (mais espalhado), mais eficiente a busca (ausência de conflitos)
         * quando há conflitos (colisão de código - dois ou mais elementos num mesmo local), é necessário fazer a busca no local todo para que não haja erros na identificação do objeto => isso torna o processo de busca mais lento
         * sempre que o método Equals é implementado, faz-se necessária a implementação do método GetHashCode para garantir que a dispersão seja feita corretamente
         */
        public override int GetHashCode()
        {
            return this._nome.GetHashCode();
        }

    }
}
