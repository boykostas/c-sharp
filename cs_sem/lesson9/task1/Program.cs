// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите значение m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n");
int n = Convert.ToInt32(Console.ReadLine());

string Numbers(int m, int n)
{
    if (m == n)
    return m.ToString();
    return m + " " + Numbers(m + 1, n);
}
System.Console.WriteLine(Numbers(m, n));