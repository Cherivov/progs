// Сформируйте двухмерный массив из неповторяющихся двузначных чисел (размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив.
// Вариант создания функции:
// Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )

int[,] array = new int[5, 5];
Random rnd = new Random();
void CreateArray(int[,] arr)
{
    int[] temp = new int[arr.GetLength(0) * arr.GetLength(1)];
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = rnd.Next(10, 100);
        int number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = rnd.Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int k = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int number = rnd.Next(1, 10);
            array[i, j] = temp[k];
            k++;
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
CreateArray(array);
printArray(array);