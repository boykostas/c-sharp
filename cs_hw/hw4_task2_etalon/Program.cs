int Prompt(string massage)
{
    System.Console.WriteLine(massage);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;    
}

int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = Prompt("Введите число: ");
System.Console.WriteLine($"Сумма всех чисел в цифре {number} равно: {SumAllDigit(number)}");
