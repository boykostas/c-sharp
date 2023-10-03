// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да

Console.WriteLine("Введите два числа.");
Console.WriteLine("Первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA * numberA == numberB)
{
    Console.WriteLine("Второе число является квадратом первого! ");
} else if (numberB * numberB == numberA) {
    Console.WriteLine("Первое число является квадратом второго! ");
} else {
    Console.WriteLine("Ни одно из чисел не является квадратом второго!");
}
