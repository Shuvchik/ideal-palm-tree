// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Clear();

Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7)
{
    Console.WriteLine("Не день недели. Соберись и попробуй ввести число от 1 до 7");
}
else if (0 < day && day < 6)
{
    Console.WriteLine("Будний день");
}
else
{
    Console.WriteLine("Выходной");
}