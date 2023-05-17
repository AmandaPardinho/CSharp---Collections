using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetModelos
{
    public class Aula : IComparable
    {
        private string _titulo;
        private int _tempo;

        public Aula(string titulo, int tempo)
        {
            this._titulo = titulo;
            this._tempo = tempo;
        }

        public int Tempo { get => _tempo; set => _tempo = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }

        public int CompareTo(object? obj)
        {
            Aula that = obj as Aula;
            return this._titulo.CompareTo(that._titulo);
        }

        public override string ToString()
        {
            return $"[Título: {_titulo}; Duração: {_tempo} minutos]";
        }
    }
}
