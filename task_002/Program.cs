// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите ещё число: ");
int b = Convert.ToInt32(Console.ReadLine());

    if (a > b)
    {
        Console.Write("Число больше ещё числа. Мах = ");
        Console.WriteLine(a);
    }
    else if (a < b)
    {
        Console.Write("Ещё число больше числа. Мах = ");
        Console.WriteLine(b);
    }
    else 
    {
        Console.Write("Число и ещё число равны");
    }