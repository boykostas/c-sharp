// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите начальное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int AckFunction (int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM != 0 && numN == 0) return AckFunction(numM - 1, 1);
    if (numM > 0 && numN > 0) return AckFunction(numM - 1, AckFunction(numM, numN - 1));
return AckFunction(numM, numN);
}

Console.WriteLine($"Функция Аккермана для чисел A({M},{N}) = {AckFunction(M, N)}");