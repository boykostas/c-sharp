// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine("Программа сгенерировала трехзначное число: " + number);
int a = number / 100;
int b = number % 10;
Console.Write(a);
Console.Write(b + " ");
