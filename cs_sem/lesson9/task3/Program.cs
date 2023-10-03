// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int n = Convert.ToInt32(Console.ReadLine());

int Numbers(int m, int n)
{
    if (n == 0)
        return 1;
    return m * Numbers(m, n -1);
}
System.Console.Write($"Число {m} в степени {n} = ");
System.Console.WriteLine(Numbers(m, n));
