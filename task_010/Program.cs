// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Clear();

Console.Write("Введите 3-значное число: ");

int number = Convert.ToInt32(Console.ReadLine());

string stringNumber = Convert.ToString(number);

Console.Write("вторая цифра этого числа: ");
Console.WriteLine(stringNumber[1]);