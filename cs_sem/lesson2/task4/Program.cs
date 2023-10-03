// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Введите 2 числа!");
Console.WriteLine("Первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA % numberB == 0) 
{
    Console.WriteLine("Первое число кратно второму!");
} else {
    Console.WriteLine("Первое число не кратно второму! Остаток после деления: " + numberA % numberB);
}