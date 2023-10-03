// Задача №18. Работа в группах
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер честверти: ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number) {
    case 1: 
        { Console.WriteLine("X > 0 && Y > 0");
        break; }
    case 2: 
        { Console.WriteLine("X < 0 && Y > 0");
        break; }
    case 3: 
        { Console.WriteLine("X < 0 && Y < 0");
        break; }
    case 4: 
        { Console.WriteLine("X > 0 && Y > 0");
        break; }
    default: 
        { Console.WriteLine("Такого номера четверти нет!");
        break; }
}