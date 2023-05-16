using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLeitura
{
    public class Curso
    {
		private IList<Aula> _aulas;
		private string _nome;
		private string _instrutor;

        public Curso(string nome, string instrutor)
        {
			this._aulas = new List<Aula>();
            this._nome = nome;
            this._instrutor = instrutor;
        }

		/* IList =>
		 * é implementado por uma classe genérica => nessecidade de passar também qual o tipo de elemento
		 * implementado sempre que se usa o ReadOnlyCollection
		 */

        public IList<Aula> Aulas
		{
			get { return new ReadOnlyCollection<Aula>(_aulas); }
            
			/* remoção do set para proteger a lista de aulas:
			 * set { _aulas = value; }
			 */
           
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
    }
}
