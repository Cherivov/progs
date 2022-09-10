// Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите длину массива: ");
int L = Convert.ToInt32(Console.ReadLine());
int res = 0;
int[] array = new int[L];

for (int i = 0; i < L; i++)
{
    int number = new Random().Next();
    array[i] = number;
    Console.Write(array[i] + " ");

}

int min = array[0];
int max = array[0];

for (int i = 0; i < array.Length; i++)
    if (min > array[i])
    {
        min = array[i];
    }
    else
    {
        if (max < array[i])
            max = array[i];
    }
res = max - min;

Console.WriteLine($"Разница между максимальным: {max} и минимальным: {min} элементом массива равна: {res}");