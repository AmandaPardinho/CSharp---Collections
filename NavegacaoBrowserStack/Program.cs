using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavegacaoBrowserStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            //definindo novo objeto
            var navegador = new Navegador();

            //criando um método para mostrar a alteração entre url
            navegador.NavegarPara("google.com");
            navegador.NavegarPara("caelum.com.br");
            navegador.NavegarPara("alura.com.br");

            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();
            //não é possível usar o método Pop numa pilha vazia => necessário verificar
            navegador.Anterior();

            navegador.Proximo();
        }
    }
}
