using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Queue fila = new Queue();

        // Enqueue: Adicionando elementos à fila
        fila.Enqueue(14);
        fila.Enqueue(23);
        fila.Enqueue(39);
        fila.Enqueue(58);

        Console.WriteLine("Elementos na fila:");
        foreach (var item in fila)
        {
            Console.WriteLine(item);
        }

        // Peek: Verificando o elemento na parte frontal da fila
        if (fila.Count > 0)
        {
            int elementoNaFrente = (int)fila.Peek();
            Console.WriteLine($"Elemento na frente da fila: {elementoNaFrente}");
        }

        // Dequeue: Removendo elementos da fila
        while (fila.Count > 0)
        {
            int elementoRemovido = (int)fila.Dequeue();
            Console.WriteLine($"Elemento removido: {elementoRemovido}");
        }

        Console.WriteLine("A fila está vazia.");
    }
}