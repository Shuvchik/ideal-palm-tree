// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void TheEnd()
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Good luck!)");
    Console.ResetColor();
    Console.ReadKey();
}

void FillArray(int[] pack)
{
    int length = pack.Length;
    int index = 0;
    while(index < length)
    {
        pack[index] = new Random().Next(100, 1000);
        index++;
    }
}

void PrintArray(int[] printPack)
{
    int count = printPack.Length;
    int position = 0;

    while(position < count)
    {
        Console.WriteLine(printPack[position]);
        position++;
    }
}

void CheckArray(int[] checkPack)

{
    int i = checkPack.Length;
    int place = 0;
    int count1 = 0;
    while (place < i)
    {
        if (checkPack[place] % 2 == 0)
        {
            count1++;
            place++;
        }
        else
        {
            place++;
        }
    }
    Console.WriteLine();
    Console.Write($"Чётных чисел в массиве вот: {count1}");
}

Console.Clear();

// int[] array = {345, 897, 568, 234};
int[] array = new int[4];

FillArray(array);
PrintArray(array);
CheckArray(array);

Console.WriteLine();
TheEnd();