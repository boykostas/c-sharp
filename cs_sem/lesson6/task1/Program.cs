// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int[] GenerateArray(int arraySize)
// {
//     int[] array = new int[arraySize];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 10);
//     }
//     return array;
//  }

//  int[] ReserveArray(int[] array)
//  {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int tmp = array[i];
//         array[i] = array[array.Length];
//         array[array.Length] =  tmp;
//     }
//  }