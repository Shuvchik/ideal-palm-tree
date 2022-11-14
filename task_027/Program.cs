// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNum(int number)
{
    int sum = 0;
    int number1 = 0;

    while (number > 0)
    {
        number1 = number % 10;
        sum = sum + number1;
        number /= 10;
    }

    return sum;
}

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Вот сумма чисел: {SumNum(number)}");