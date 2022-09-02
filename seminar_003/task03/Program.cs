//  Напишите программу, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N. Полученный массив вывести на экран.
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int index = 0;
while (index < N)
{
    array[index] = (index + 1) * (index + 1) * (index + 1);
    Console.Write(array[index] + " ");
    index++;
}