// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Prompt(string txt)
{
    System.Console.WriteLine(txt);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] FillMatrix(int rows, int cols)
{
    double[,] array = new double[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = Math.Round(rand.Next(100, 1000) * 0.1, 1);
            Console.Write("{0,0}", array[i, j]);
            Console.Write("\t");
        }
        Console.WriteLine();

    }
    return array;
}

int line = Prompt("Введите количество строк: ");
int stoblets = Prompt("Введите количество столцов: ");
double[,] array = FillMatrix(line, stoblets);