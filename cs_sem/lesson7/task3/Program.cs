

// Решение в группах задач:
// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateOutputArray(int m, int n)
{
    int[,] array = new int [m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

int[,] MultIndex(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
            {
                array[i, j] *= array[i, j];
            }
            Console.Write(array[i, j] + "\t");
        } 
        Console.WriteLine();
    }
    return array;
}

int a = Prompt("Введите количество строк: ");
int b = Prompt("Введите количество столбцов: ");
Console.WriteLine();

int[,] num = CreateOutputArray(a, b);
Console.WriteLine();
MultIndex(num);