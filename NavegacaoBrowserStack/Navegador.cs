namespace NavegacaoBrowserStack
{
    public class Navegador
    {
        //Stack = pilha => o último elemento a entrar é o primeiro elemento a sair da pilha
        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoProximo = new Stack<string>();
        private string atual = "vazia";

        public Navegador()
        {
            Console.WriteLine($"Página atual: {atual}");
        }

        public void Anterior()
        {
            if (historicoAnterior.Any())
            {
                historicoProximo.Push(atual);
                //método Pop => pega o próximo elemento de uma pilha e retorna uma string
                atual = historicoAnterior.Pop();
                Console.WriteLine($"Página atual: {atual}");
            }
        }

        public void NavegarPara(string url)
        {
            //método Push => adiciona um elemento a uma pilha
            historicoAnterior.Push(atual);
            atual = url;
            Console.WriteLine($"Página atual: {atual}");
        }

        public void Proximo()
        {
            if (historicoProximo.Any())
            {
                historicoAnterior.Push(atual);
                atual = historicoProximo.Pop();
                Console.WriteLine($"Página atual: {atual}");
            }            
        }
    }
}