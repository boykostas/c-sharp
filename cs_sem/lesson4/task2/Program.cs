// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

int Prompt()
{
    Console.WriteLine("Введите количество элементов: ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) {
        arr[i] = new Random().Next(0, 2);
    }   
    return arr;
}

int[] newArr = CreateArray(Prompt());

Console.WriteLine($"[{String.Join(", ", newArr)}]");