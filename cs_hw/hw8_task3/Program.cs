// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int Prompt(string txt)
{
    System.Console.WriteLine(txt);
    return Convert.ToInt32(Console.ReadLine());
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] numArray1, int[,] numArray2, int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < resultArray.GetLength(1); k++)
            {
                sum += numArray1[i, k] * numArray2[k, j];
            }
            resultArray[i, j] = sum;
        }
    }
}

int m = Prompt("Введите количество строк в матрицах: ");
int n = Prompt("Введите количество столбцов в матрицах: ");
int z = m;
int p = n;

int[,] numArray1 = new int[m, n];
CreateArray(numArray1);
System.Console.WriteLine();
System.Console.WriteLine("Первая матрица: ");
PrintArray(numArray1);

int[,] numArray2 = new int[m, n];
CreateArray(numArray2);
System.Console.WriteLine();
System.Console.WriteLine("Вторая матрица: ");
PrintArray(numArray2);

int[,] resultArray = new int[z, p];

if (m != n)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Невозможно перемножить матрицы! Необходимо ввести одинаковый размер строк и столбцов!");
}
else
{
    System.Console.WriteLine();
    Console.WriteLine($"Произведение первой и второй матриц:");
    MultiplyMatrix(numArray1, numArray2, resultArray);
    PrintArray(resultArray);
}


