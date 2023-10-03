// Методы!!!
// Вид №1
// void Method1() 
// {
//     Console.WriteLine("Автор ...");
// }
// Method1();

//Вид №2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Привет мир!");

//Вид №2 вариант №2
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while(i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Какой то текст", 5);

// Вид №3
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine("Сегодня на дворе " + year + " год!");
// Console.WriteLine();

// Вид №4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i < count)
//     {
//         result += text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "qwerty ");
// Console.WriteLine(res);

//Цикл for
// for(int i = 1; i <= 10; i++)
// {
//     for(int j = 1; j <=10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

// ===== Работы с текстом =====
// Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
// заменить большими «К», а большие «С» заменить на маленькие «с».


// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//            + "ежели Вас послали бы вместо нашего милого Винценгероде, "
//            + "Вы бы взяли приступом согласие прусского Короля. "
//            + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//         for (int i = 0; i < length; i++)
//         {
//             if(text[i] == oldValue) result += $"{newValue}";
//             else result += $"{text[i]}";
//         }
//     return result;
// }

// string newText = Replace(text, 'к', 'К');
// newText = Replace(newText, ' ', '_');
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);
// Console.WriteLine("Количество символов введенных в тексте: " + text.Length); 

int[] arr = {1, 3, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SeletionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;

    }
}

PrintArray(arr);
SeletionSort(arr);

PrintArray(arr);
