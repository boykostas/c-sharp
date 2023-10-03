int Prompt(string massage)
{
    System.Console.WriteLine(massage);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;    
}

int [] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}

int length = Prompt("Введите длину массива: ");
int min = Prompt("Введите минимальное число массива: ");
int max = Prompt("Введите максимальное число массива: ");
int[] array = GenerateArray(length, min, max);
System.Console.Write("Сгенерированный массив: ");
PrintArray(array);
