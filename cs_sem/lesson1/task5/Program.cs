// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine()); 
int div = 0;

if(num >= 100 && num < 1000) {
    div = num % 10;
    Console.WriteLine(div);
} else {
    Console.WriteLine("Введите обязательно трехзначное число!");
}

