// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// метод принимает на ввод какое-то число
int Prompt(string massage) 
{
    Console.Write(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

// метод проверяет число, чтобы оно было ровно 5 цифрам
bool ValidateNum(int num) 
{
    // num = Prompt("Введите пятизначное число: ");
    if (num < 10000 || num > 100000) 
    {
        Console.WriteLine("Вы ввели неправильное число!");
        return false;
    }
    return true;
}

//проверкf на полидромность
int number = Prompt("Введите пятизначное число: ");
if (ValidateNum(number))
{
    string arr = number.ToString();
    if (arr[0] == arr[4] && arr[1] == arr[3])
        Console.WriteLine($"Число {number} является полидроном!");
    else
        Console.WriteLine($"Число {number} не является полидроном!");
}
