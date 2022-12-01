// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// void FillArray(int[] pack)
// {
//     int length = pack.Length;
//     int index = 0;
//     while(index < length)
//     {
//         pack[index] = new Random().Next(-100, 101);
//         index++;
//     }
// }

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
    int place = 1;
    int a = place + 2;
    int count1 = 0;
    
    while (place < i)
    {
        count1 = checkPack[place] + checkPack[a];
        place = place + 2;
        a += 2;
    }

    Console.WriteLine();
    Console.Write($"Сумма вот: {count1}");
}

Console.Clear();

// int[] array = {3, 7, 23, 12};
// int[] array = {-4, -6, 89, 6};

// int[] array = new int[8];
int[] array = {2, 2, 2, 2, 2, 2};
//FillArray(array);
PrintArray(array);
CheckArray(array);