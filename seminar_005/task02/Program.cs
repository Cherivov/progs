// Задайте одномерный массив, заполненный случайными числами. Найдите сумму четных элементов, стоящих на нечётных позициях (позиция - индекс элемента в массиве).

Console.WriteLine("Введите длину массива: ");
int L = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int[] array = new int[L];

for (int i = 0; i < L; i++)
{
    int number = new Random().Next();
    array[i] = number;
    Console.WriteLine(array[i] + " ");
    if ((array[i] % 2 == 0) && (i % 2 == 1))
    {
        sum=sum+array[i];
    }
}
Console.WriteLine($"Сумма четных элементов, стоящих на нечётных позициях: {sum}");