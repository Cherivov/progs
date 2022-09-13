// Задайте двумерный массив размером m×n, заполненный случайными вещественными (тип double) числами.
Console.WriteLine("Введите Количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double number = new Random().NextDouble() * 100.00 - (-100.00) + (-100.00);
        number = Math.Round(number, 1);
        array[i, j] = number;
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
