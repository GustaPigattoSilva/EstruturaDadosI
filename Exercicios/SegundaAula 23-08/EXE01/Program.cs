int[] numbers = {1, 8, -6, 2, 11, 7, 3, -3, 9, 10};

Console.WriteLine("Números Aleatórios");
for (int i = 0; i <numbers.Length; i++)
{
    Console.WriteLine( $"numbers[{i}] = {numbers[i]}" );
}

Array.Sort(numbers);

Console.WriteLine("Números Ordenados do Menor para o Maior");
for (int i = 0; i <numbers.Length; i++)
{
    Console.WriteLine( $"numbers[{i}] = {numbers[i]}" );
}