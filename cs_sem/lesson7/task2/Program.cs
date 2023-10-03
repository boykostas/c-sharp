
// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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
            array[i, j] = i + j;
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}
int a = Prompt("Введите количество строк: ");
int b = Prompt("Введите количество столбцов: ");
Console.WriteLine();

CreateOutputArray(a, b);