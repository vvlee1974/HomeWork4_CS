/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

/*
АЛГОРИТМ
1. Получаем на вход два числа: А, В. 
2. Число В - натуральное число (В >= 1)
3. Метод возведения числа А в степень В через цикл for
*/


double GetNumberA(string message)
{
    double result = 0;

    while (true)
    {
        Console.Write(message);

        if (double.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        Console.WriteLine("Ввели не число. Повторить ввод! ");
    }

    return result;
}

double GetNumberB(string msg)
{
    double res = 0;

    while (true)
    {
        Console.Write(msg);

        if (double.TryParse(Console.ReadLine(), out res) && res >= 1)
        {
            break;
        }
        Console.WriteLine("Ввели не натуральное число. Повторить ввод! ");
    }

    return res;
}
     

double GetNumberAB(double numA, double numB)
{
    double numAB = numA;
    
    for (int i = 1; i < numB; i++)
    {
        numAB *= numA;
    }

    return numAB;
}

double numA = GetNumberA("Введите любое число А: ");
double numB = GetNumberB("Введите натуральное число В: ");

double numberAB = GetNumberAB(numA, numB);

Console.WriteLine($"({numA}) в степени {numB} = {numberAB} ");

