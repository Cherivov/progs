// Напишите программу, которая на вход принимает позиции (две) элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] array = new int[4, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int number = new Random().Next(1, 100);
        array[i, j] = number;
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("Введите строку элемента: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец элемента: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

if (m > array.GetLength(0) || n > array.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine(array[m - 1, n - 1]);
}
