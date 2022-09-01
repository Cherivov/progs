Console.WriteLine("Введите число А: ");
int num_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int num_b = Convert.ToInt32(Console.ReadLine());

int exponentiation(int a, int b)
{
    int res = 1;
    for (int i = 0; i < b; i++)
    {
        res = res * a;
    }
    return res;
}

int result = exponentiation(num_a, num_b);

Console.WriteLine($"Результатом возведения числа {num_a} в степень {num_b} будет: {result}");