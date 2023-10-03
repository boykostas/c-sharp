// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Prompt(string txt)
{
    System.Console.WriteLine(txt);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateArray(int n, int m)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    return array;
}

double ArithmeticMean(int[,] array)
{
    double count = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            count = count + array[j, i];
        }
        System.Console.WriteLine($"Среднее арифметическое в столбце {i + 1}: " + Math.Round((count / array.GetLength(0)), 2));
        count = 0;
    }
    return count;
}

int line = Prompt("Введите количество строк: ");
int stoblets = Prompt("Введите количество столбцов: ");
System.Console.WriteLine();
int[,] array = CreateArray(line, stoblets);
System.Console.WriteLine();
ArithmeticMean(array);

