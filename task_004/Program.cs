// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите ещё число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Ну и ещё одно: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a == b && b == c && a == c)
{
    Console.Write("Все числа равны");
}
else
{
    int max = Convert.ToInt32(Math.Max(a, Math.Max(b, c)));
    Console.Write("Максимальное = ");
    Console.WriteLine(max);
}