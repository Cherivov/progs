// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] array = new int[4, 4];
double[] avg_array = new double[array.GetLength(0)];

for (int j = 0; j < array.GetLength(0); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int number = new Random().Next(1, 100);
        array[i, j] = number;
        sum = sum + number;
    }
    avg_array[j] = sum / array.GetLength(0);
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < avg_array.Length; i++)
{
    Console.Write(avg_array[i] + " ");
}

