// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

//Вариант №1
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = -num;
// Console.WriteLine("Вывод целых чисел: ");
// while (count <= num) {
//     Console.Write(" " + count);
//     count++;
// }

// Вариант №2
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вывод целых чисел: ");
for (int count = -num; count < num; count++) {
    Console.Write(count + " ");
}
