// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GetArray()
{
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

int SumPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i] > 0)
        sum += array[i];
    return sum;
}

int SumNegative(int[] array)
{
    int sum = 0;
    foreach (int el in array)
        sum += el < 0 ? el : 0;
    return sum;
}

int[] array = GetArray();
Console.WriteLine(String.Join(" ", array));
Console.WriteLine("Our sum of positive is {0}. Our sum of negative is {1} ", SumPositive(array), SumNegative(array));
SumPositive(array);
SumNegative(array);
