// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Numbers(int m)
{
    if (m / 10 == 0)
        return m;
    return m % 10 + Numbers(m / 10);
}
System.Console.Write($"Сумма числа {num} = ");
System.Console.WriteLine(Numbers(num));