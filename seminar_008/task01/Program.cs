// Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] array = new int[4, 4];
Random rnd = new Random();

void fillArray(int[,] array)        //заполнение массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int number = rnd.Next(1, 10);
            array[i, j] = number;
        }
    }
}

void printArray(int[,] array)       //Вывод массива на экран 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int findMin(int[,] array)
{
    int str = 0;
    int min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];

        }

        Console.Write(sum + "\t");
        if (i == 0)
        {
            min = sum; 
            str = i + 1;
        }
        if (sum < min)
        {
            min = sum;
            str = i + 1;
        }
    }
    return str;
}

fillArray(array);
Console.WriteLine();
printArray(array);

Console.WriteLine("Cтрока с наименьшей суммой элементов: " + findMin(array));