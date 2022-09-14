// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int n = 3;
int m = 2;
int[,] array = new int[n, m];
double[] avg_array = new double[m];
Random number = new Random();
for (int j = 0; j < m; j++)
{
    double sum = 0;
    for (int i = 0; i < n; i++)
    {
        array[i, j] = number.Next(1, 100);
        sum = sum + array[i, j];
    }
    avg_array[j] = sum / n;
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < avg_array.Length; i++)
{
    Console.Write(Math.Round(avg_array[i], 1) + " ");
}

