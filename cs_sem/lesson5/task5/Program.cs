// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArray()
{
    int[] array = new int[11];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

int[] newArray = GetArray();

int[] Mult(int[] newArray)
{
    int size = newArray.Length / 2;
    if (newArray.Length % 2 == 1)
        size += 1;
    int[] smallArray = new int[size];
    for (int i = 0; i < smallArray.Length; i++)
    {
        smallArray[i] = newArray[i] * newArray[newArray.Length - 1 - i]; 
    }
    if (size % 2 == 0)
        smallArray[size - 1] = newArray[newArray.Length / 2];
    return smallArray;
}

Console.WriteLine(String.Join(" ", newArray));
Console.WriteLine(String.Join(" ", Mult(newArray)));



// void Mult(int[] array)
// {
//     int min = array[0];
//     int max = array[array.Length - 1];
//     int mid = (array.Length - 1) / 2;
//     for (int i = 0; i < mid; i++)
//     {
        
//         min += 1;
//         max -= 1;
//     } 
//     Console.Write("Выводим: " + count + "\n");
// }

