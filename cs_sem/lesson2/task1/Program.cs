Random rand = new Random();
int number = rand.Next(10,100);
Console.WriteLine();
int max = number / 10;
int min = number % 10;
if(max < min) 
    Console.WriteLine("Наибольшая цифра числа это ");
else Console.WriteLine();
