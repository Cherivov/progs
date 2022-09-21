// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] array = new int[4, 4];

Random rnd = new Random();

void fillArray(int[,] array)        //заполнение массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int number = rnd.Next(1, 100);
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

void SortMaxToMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {


            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int tmp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = tmp;
                }
            }
        }
    }
}

fillArray(array);
printArray(array);
Console.WriteLine();
SortMaxToMin(array);
printArray(array);