class Program
{
    static void Main(string[] args)
    {
        StackOfString stack = new StackOfString(5);

        stack.Push("Nada");
        stack.Push("Não Entendi");
        stack.Push("EU");

        Console.WriteLine("Elemento no topo da pilha: " + stack.Peek());

        Console.WriteLine("Desempilhando elementos:");
        while (!stack.IsEmpty())
        {
            Console.WriteLine(stack.Pop());
        }

        Console.WriteLine("Número de elementos na pilha: " + stack.Count());
    }
}
