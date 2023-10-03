// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine("Программа сгенерировала трехзначное число: " + number);
int a = number % 100;
int numberA = a / 10;
Console.Write(numberA + " ");
