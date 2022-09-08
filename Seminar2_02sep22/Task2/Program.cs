// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.Write("Введите число: ");
long x = Convert.ToInt64(Console.ReadLine());

int y = 10;
int count = 1;

if (x < 100 && x > -100)
{
    Console.Write("Третьей цифры нет");
}

else
{
    while (x / y > 99 || x / y < -99)
    {
        y = y * 10;
        count = count * 10;
    }

    long result = (x % y) / count;
    Console.Write($"Третья цифра: {Math.Abs(result)}");
}
