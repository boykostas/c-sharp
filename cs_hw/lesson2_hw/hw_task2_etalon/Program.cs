﻿// Эталонное решение задания №2!

int Prompt(string massage)
{
    Console.Write(massage);
    // string value = Console.ReadLine();
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int GetThirdRank(int number)
{
    while(number > 999) 
    {
        number /= 10;
    }
    return number % 10;   
}

bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет!");
        return false;
    }
    return true;
}

int number = Prompt("Введите число > ");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}