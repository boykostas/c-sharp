// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int Prompt()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}
int num = Prompt();
int len = Length(num);

Console.Write($"Сумма цифр в числе {num} равно: {Sum(num, len)} ");

// Подсчет количества символов в числе
int Length(int a)
{
    int i = 0;
    for (i = 0; a > 0; i++)
    {
        a /= 10;
    }
    return i;
}

int Sum(int a, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += a % 10;
        a /= 10;
    }
    return sum;
}
