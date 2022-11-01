// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Palindrom(int digit)
{
    int result = 0;
    if (digit / 10000 == digit % 10 && (digit / 1000) % 10 == (digit % 100) / 10)
    {
        result = 1;
    }
    // else
    // {
    //     result = 2;
    // }
    return result;
}

Console.Clear();

Console.Write("Введите пятизначное число: ");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit < 10000 || digit > 99999)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Это не пятизначное. Попробуй ещё");
    Console.ResetColor();
}

int result = Palindrom(digit);

if (result == 1)
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("НЕ палиндром");
}
// Console.WriteLine("Это не пятизначное. Попробуй ещё");

// if (a / 10000 == a % 10 && (a / 1000) % 10 == (a % 100) / 10)
// {
//     Console.WriteLine("Палиндром");
// }
// else
// {
//     Console.WriteLine("НЕ палиндром");
// }