Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int length(int number)
{
    int num_len = 1;
    while ((number /= 10) >= 1) ++num_len;
    return num_len;
}

int a_len = length(number);
int n = 0;

int[] array = new int[a_len];
int index = 0;
while (n < a_len)
{

    int a = Convert.ToInt32(Math.Pow(10, n + 1));
    int b = Convert.ToInt32(Math.Pow(10, n));
    int digit = Convert.ToInt32((number % a) / b);
    array[index] = digit;
    index++; n++;
}
int sum=0;
for (int i = 0; i < a_len; i++)
{
    if ((array[i]>0) && (number % array[i] == 0))
    {
        sum = sum + array[i];
    }
}

Console.WriteLine($"Сумма цифр, которые являются, делителями числа {number} равна {sum}");



