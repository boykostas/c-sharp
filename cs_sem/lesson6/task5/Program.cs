//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.WriteLine("Введите длинну массива: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] arr1 = new int[a];
for (int i = 0; i < a; i++)
{
    arr1[i] = new Random().Next(1, 20);
}
Console.WriteLine("Выводим первый массив: ");
for (int i = 0; i < arr1.Length; i++)
{
    Console.Write(arr1[i] + " ");
}
System.Console.WriteLine("");
int[] arr2 = new int[arr1.Length];
for (int i = 0; i < arr2.Length; i++)
{
    arr2[i] = arr1[i];
}
Console.WriteLine("Второй массив: ");

for (int i = 0; i < arr2.Length; i++)
{
    Console.Write(arr2[i] + " ");
}