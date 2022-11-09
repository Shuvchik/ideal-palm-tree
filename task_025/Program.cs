// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Вариант #1

void exponentiation(int numA, int numB)
{
    int pow = 1;
    int sum = 0;
    
    for (int i = 1; i <= Math.Abs(numB); i++)
    {
        sum = pow * numA;
        pow = sum;
    }
    Console.WriteLine($"{numA} в степени {numB} = {pow}");
}

Console.Clear();

Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите ещё число: ");
int numB = Convert.ToInt32(Console.ReadLine());

exponentiation(numA, numB);


// Вариант #2

// Console.Clear();

// Console.Write("Введите число: ");
// int numA = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите ещё число: ");
// int numB = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Math.Pow(numA, numB));