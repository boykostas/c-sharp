// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// int a = 25, b = 5;
// int a = 2, b = 10 
// int a = 9, b = -3 
// int a = -3 b = 9 

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
// int result = num2 * num2;

if (num2 * num2 == num1) 
Console.WriteLine("Является!"); 
else 
Console.WriteLine("Не является!");