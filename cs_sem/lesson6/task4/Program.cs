﻿// Решение в группах задач:
// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
arr[0] = 0;
arr[1] = 1;
System.Console.WriteLine(arr[0] + " ");
System.Console.WriteLine(arr[1] + " ");
for (int i = 2; i < a; i++)
{
    arr[i] = arr[ i - 1 ] + arr[i - 2];
    Console.Write(arr[i] + " ");
}