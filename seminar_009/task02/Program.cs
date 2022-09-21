// Напишите программу, которая спирально заполнит числами от 1 до 16 двумерный массив 4 на 4.

int n = 4;
int[,] array = new int[n, n];


void fillArray(int[,] array)
{
    int tmp = 1;
    int i = 0;
    int j = 0;
    while (tmp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = tmp;
        tmp++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
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



fillArray(array);
printArray(array);