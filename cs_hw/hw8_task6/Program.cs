﻿// Необязательное задание:
// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

Console.WriteLine("Введите количество строк треугольника Паскаля:");
int numberRows = Convert.ToInt32(Console.ReadLine());

int[,] FillPascalArray(int numberRows)
{
    int rows = numberRows;
    int columns = numberRows + 2;
    int[,] array = new int[rows, columns];
    array[0, 1] = 1;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
        }
    }
    return array;
}

void PrintPascalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = array.GetLength(0); k > i; k--)
        {
            Console.Write("  ");
        }
        for (int j = 1; j < array.GetLength(1); j++)
        {
            Console.Write("{0,4}", array[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] array = FillPascalArray(numberRows);
Console.WriteLine();

PrintPascalArray(array);