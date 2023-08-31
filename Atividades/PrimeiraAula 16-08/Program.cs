int[] numbers;
numbers = new int[5];

numbers [0] = 9;
numbers [1] = -11;
numbers [2] = 5;
numbers [3] = 7;
numbers [4] = -4;
//numbers [5] = 8:  (ERROUU, fora dos limites)

int[] numbers2 = new int[] {9,-11,5,7,-4};

int[] numbers3 = {9,-11,5,7,-4};

for(int i = 0; i < numbers.Length; i++ )
{
    Console.WriteLine( numbers[i]);
}