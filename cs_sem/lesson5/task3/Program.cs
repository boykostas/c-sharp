﻿// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

//дописать программу
int [] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}
int InputNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
string text2 = "Введите размер массива";
int size2 = InputNumber(text2);
int [] newArray = GetArray(size2);

// Console.WriteLine("Введите произвольное целое число");
// int find = Convert.ToInt32(Console.ReadLine());
int find = InputNumber("Введите произвольное целое число: ");
int index = 0;
int b = 0;
while (index < size2)
{
    if (newArray[index] == find)
    {
        Console.WriteLine("Искомый элемент найден в массиве. Его индекс = " + index + ", его значение = " + find);
        b += 1;
        break;
    }
    index = index + 1;        
}
if (b == 0)
    {
        Console.WriteLine("Искомый элемент не найдет в массиве.");
    }
Console.Write("Сгенерированный массив: ");
Console.WriteLine(String.Join(" ", newArray));