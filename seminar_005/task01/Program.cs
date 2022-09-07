// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите длину массива: ");
int L = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] array = new int[L];

for (int i = 0; i < L; i++)
{
    int number = new Random().Next(100, 1000);
    array[i] = number;
    Console.WriteLine(array[i] + " ");
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество четных чисел: {count}");