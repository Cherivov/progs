Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int length(int number)
{
    int num_len = 1;
    while ((number /= 10) >= 1) ++num_len;
    return num_len;
}
int a_len = length(number);
int i, k;
Boolean polind = false;
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
i = 0;
k = a_len - 1;
if (a_len > 2)
{
    if (a_len % 2 == 0)
    {
        while (i <= k - 1)
        {
            if ((array[i]) == (array[k]))
            {
                i++; k--;
                polind = true;
            }
            else
            {

                polind = false;
                break;
            }
        }
    }
    else
    {
        while (i < k - 1)
        {
            if ((array[i]) == (array[k]))
            {
                i++; k--;
                polind = true;
            }
            else
            {

                polind = false;
                break;
            }
        }
    }
}
else
{
    if (a_len == 2)
    {
        if ((array[0]) == (array[1]))
        {
            polind = true;
        }
        else
        {

            polind = false;
        }
    }
}
switch (a_len)
{
    case 1:
        Console.WriteLine("вы ввели одну цифру");
        break;
    default:
        if (polind == true)
        {
            Console.WriteLine("Число " + number + " является полиндромом");
        }
        else
        {
            Console.WriteLine("Число " + number + " не является полиндромом");
        }
        break;
}