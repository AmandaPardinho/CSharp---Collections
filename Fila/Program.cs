using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila
{
    public class Program
    {
        //Queue => fila => o primeiro elemento a entrar é o primeiro a sair
        static Queue<string> pedagio = new Queue<string>();

        static void Main(string[] args)
        {
            //adicionando elementos à fila => método Enqueue (enfileirar)
            Enfileirar("van");
            Enfileirar("kombi");
            Enfileirar("guincho");
            Enfileirar("pickup");

            //liberando carros => método Dequeue (desenfileirar) => retorna o elemento que saiu
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();

        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                if(pedagio.Peek() == "guincho")
                {
                    Console.WriteLine("Guincho está fazendo o pagamento");
                }
                string veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da fila: {veiculo}");
                ImprimirFila();
            }
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: {veiculo}");
            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            //exibindo elementos da fila
            foreach (var car in pedagio)
            {
                Console.WriteLine($"Fila: {car}");
            }
        }
    }
}