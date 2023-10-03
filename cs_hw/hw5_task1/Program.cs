﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;
}

int EvenNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) 
            count ++;
    }
    return count;
}

int[] arr = GetArray(10);
Console.WriteLine(String.Join(" ", arr));
int num = EvenNumber(arr);
Console.WriteLine("Количество четных чисел в массиве: " + num);

