// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void cube(int N)
{
    int count = 1;

    if (N > 0)
    {
        while (count < N)
        {
            Console.Write(Math.Pow(count, 3) + ", ");
            count++;
        }
        Console.Write(Math.Pow(N, 3));
    }
    else if (N < 0)
    {
        while (count <= Math.Abs(N))
        {
            Console.Write($"-{Math.Pow(count, 3)} ");
            count++;
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("Ну это ноль");
        Console.ResetColor();
    }

}

Console.Clear();

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ну вот они, кубы от 1 до {N}: ");
Console.ForegroundColor = ConsoleColor.Green;
cube(N);
Console.ResetColor();
