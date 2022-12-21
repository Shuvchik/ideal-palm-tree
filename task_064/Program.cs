// Задача 64:
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int n = InputInt("Введите число ");
int m = 1;
if (n < 1)
{
    Console.WriteLine("Число не положительное");
}

Console.WriteLine(NaturalNumber(n, m));