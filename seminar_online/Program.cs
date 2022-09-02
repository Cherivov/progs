// Напишите программу, которая принимает на вход целое число и выдаёт количество цифр в числе,
// которые являются четными.
//  которые больше среднего арифметического среди всех цифр этого числа.
// 1256 -> 2 (ср. арифм 3.5)
// 45234 -> 3 (ср. арифм 3.6)
// Рекомендация: 
// среднее арифметическое среди цифр числа вычислить в отдельной функции
// кол-во цифр в числе больших заданного вычислить в отдельной функции

int number = Convert.ToInt32(Console.ReadLine());
int count_even = 0;

int length(int number)
{
    int num_len = 1;
    while ((number /= 10) >= 1) ++num_len;
    return num_len;
}
int n_len = length(number);

int[] array = new int[n_len];
int i = 0;
int tmp = number;
while (i < n_len)
{
    array[i] = tmp % 10;
    tmp = tmp / 10;
    Console.WriteLine(array[i]);
    i++;
}
i = 0;
while (i < n_len)
{
    if (array[i] % 2 == 0)
    {
        count_even++;
        
    }
    i++;
}
Console.WriteLine(count_even);