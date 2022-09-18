// Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Введите количество строк первой матрицы: ");
int mf = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы: ");
int nf = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк второй матрицы: ");
int ms = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы: ");
int ns = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = new int[mf, nf];
int[,] secondArray = new int[ms, ns];
int[,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];

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

void ProdTwoArray(int[,] arrayfirst, int[,] arraysecond)
{
    for (int i = 0; i < arrayfirst.GetLength(0); i++)
    {
        for (int j = 0; j < arraysecond.GetLength(1); j++)
        {
            for (int k = 0; k < arraysecond.GetLength(0); k++)
            {
                resultArray[i, j] += arrayfirst[i, k] * arraysecond[k, j];
            }
        }
    }
}



if (firstArray.GetLength(1) != secondArray.GetLength(0))
{
    Console.WriteLine("Матрицы нельзя перемножить");
}
else
{
    Console.WriteLine("Первая матрица");
    fillArray(firstArray);
    printArray(firstArray);

    Console.WriteLine("Вторая матрица");
    fillArray(secondArray);
    printArray(secondArray);
    
    Console.WriteLine("Результат");
    ProdTwoArray(firstArray, secondArray);
    printArray(resultArray);
}