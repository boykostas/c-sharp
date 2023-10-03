// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int Prompt()
{
    Console.WriteLine("Введите количество элементов: ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) {
        arr[i] = new Random().Next(0, 1000);
    }   
    return arr;
}

int[] newArr = CreateArray(Prompt());

Console.WriteLine($"[{String.Join(", ", newArr)}]");