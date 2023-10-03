// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите начальное число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное число M:");
int N = Convert.ToInt32(Console.ReadLine());

void NumbersSum (int numM, int numN, int sum)
{
    if (numM > numN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} = {sum}"); 
        return;
    }
    sum = sum + (numM++);
    NumbersSum(numM, numN, sum);
}

NumbersSum(M, N, 0);