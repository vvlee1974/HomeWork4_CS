/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

/*
Алгоритм

1. Получить число с консоли
2. Получить количество цифр в числе
3. Получить сумму цифр через цикл

*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        Console.WriteLine("Введено не число. Повторить ввод!");
    }

    return result;
}

int number = GetNumber("Введите любое число: "); // 4321
int numdig = number.ToString().Length; // 4


int GetSum(int number)
{
    int n = 0;

    for (int i = 0; i < numdig; i++, number /= 10) // при каждой итерации уменьшаем  number делением нацело: (number/10). (4321, 432, 43, 4)
    {
        n += number % 10; // получаем последнюю цифру числа number и прибавляем n. (1+2+3+4)
    }
    return n;
}

double sumdigit = GetSum(number);

Console.WriteLine(Math.Abs(sumdigit));


