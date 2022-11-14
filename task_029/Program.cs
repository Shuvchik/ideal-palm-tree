// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int[] array = {1, 2, 5, 7, 19};
int[] array1 = {6,1, 33};

Console.Write("Вот массив: ");
Console.WriteLine($" [ {String.Join(", ", array)} ]");

Console.Write("И вот ещё массив: ");
Console.WriteLine($" [ {String.Join(", ", array1)} ]");