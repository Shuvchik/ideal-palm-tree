// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int k = 2;

Console.WriteLine("Вот они: ");

while (k <= n)
{
    // Console.WriteLine("Вот они: ");
    Console.Write(k);
    Console.Write(", ");
    k += 2;
}
