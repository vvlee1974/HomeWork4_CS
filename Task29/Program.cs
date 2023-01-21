/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

все 8 элементов должны получить за один Console.ReadLine();
подсказка: использовать потом метод string.Split();
*/

/*
АЛГОРИТМ
1. Метод получения строки из консоли с последующим её форматированием
2. Метод печати и преобразования числового массива из входящей строки
*/


using System.Text.RegularExpressions;

string GetString(string message)
{
    Console.Write(message);

    string s = Console.ReadLine() ?? " ";

    s = new string(s.Where(c => !char.IsPunctuation(c)).ToArray());

    string pattern = @"\s+";
    string target = " ";
    Regex regex = new Regex(pattern);

    string result = regex.Replace(s, target);

    return result;
}

void PrintArray(string str)
{
    
    int[] array = str.Split(' ').Select(x => int.Parse(x)).ToArray();
    
    if (array.Length == 8)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Необходимо ввести восемь элементов.");
    }
    Console.WriteLine($"array.Length = {array.Length}");

}

string str = GetString("Введите через пробел восемь элементов: ");

PrintArray(str);



/*
using System.Text.RegularExpressions;

string[] GetStringArray(string message)
{
    Console.Write(message);

    string s = Console.ReadLine() ?? " ";
    s = new string(s.Where(c => !char.IsPunctuation(c)).ToArray()); //  из string "15,   46*  46,,, '87   15" получаем string "15 46 46 87 15"

    string pattern = @"\s+"; // ищем один и более пробелов в строке
    string target = " "; // меняем на один пробел
    Regex regex = new Regex(pattern);
    string result = regex.Replace(s, target); // заменяем пробелы, идущие подряд, на один

    string[] res = result.Split(" "); // получаем массив из введенной строки со всеми форматированиями

    return res;
}

void PrintArray(string[] array)
{
    if (array.Length == 8)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Необходимо ввести восемь элементов.");
    }
}


string[] a = GetStringArray("Введите через пробел восемь элементов: ");

PrintArray(a);

Console.WriteLine($"array.Length = {a.Length}");

*/

