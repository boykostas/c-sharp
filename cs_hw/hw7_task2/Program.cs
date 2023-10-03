
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

int numA = Prompt("Введите количество строк: ");
int numB = Prompt("Введите количество столбцов: ");
System.Console.WriteLine();
int[,] numC = CreateArray(numA, numB);

int PosX = Prompt("Введите позицию первого элемента: ");
int PosY = Prompt("Введите позицию второго элемента: ");

if (PosX > numC.GetLength(0) || PosY > numC.GetLength(1))
{
    System.Console.WriteLine("Такого элемента в массиве нет!");
}
else
{
    System.Console.WriteLine($"Значение элемента {PosX} строки и {PosY} столбца равно = {numC[PosX - 1, PosY - 1]}");
}