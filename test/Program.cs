Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int num_len = 1;
int numbrForWhile = number;
while ((numbrForWhile /= 10) >= 1) ++num_len;
int n = 0;
int[] array = new int[num_len];
int i, k;
while (n < num_len)
{
    int a = Convert.ToInt32(Math.Pow(10, n + 1));
    int b = Convert.ToInt32(Math.Pow(10, n));
    int digit = Convert.ToInt32((number % a) / b);
    array[index] = digit;
    index++; n++;
}

if (num_len > 2)
{
    i = 0;
    k = num_len - 1;
    if (num_len % 2 == 0)
    {
        i = 0;
        k = num_len - 1;
        while (i < k)
        {
            if ((array[i]) == (array[k]))
            {
                i++; k--;
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("Число не является полиндромом");
                break;
            }
            i++; k--;

            Console.WriteLine("Число является Полиндромом");
        }
    }


    else
    {
        i = 0;
        k = num_len - 1;
        while (i < k - 1)
        {
            if ((array[i]) == (array[k]))
            {
                i++; k--;
                Console.WriteLine(k);
            }
            else
            {
                Console.WriteLine("Число не является полиндромом");
                break;
            }
            i++; k--;

            Console.WriteLine("Число является Полиндромом");
        }
    }
}
else
{
    i = 0;
    k = num_len - 1;
    if (num_len == 2)
    {
        if ((array[i]) == (array[k]))
        {
            Console.WriteLine("Число является Полиндромом");
        }
        else
        {
            Console.WriteLine("Число не является полиндромом");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели одну цифру");
    }
}


// if ((digit_first == digit_fifth) && (digit_second == digit_fourth))
// {
//     Console.WriteLine("Ура, число: " + number + " является полиндромом");
// }
// else
// {
//     Console.WriteLine("Увы, число: " + number + " не является полиндромом");
// }


// int x = 912345;

// // int b = UIntPtr.Size(a);
// // Console.WriteLine(b);
// // int GetWholeDigitCount(decimal x)
// // {
// //     x = Math.Abs(x);

// int count = 1;
// while ((x /= 10) >= 1) ++count;
// // return count;
// // }
// // int GetFractionalDigitCount(a x)
// // {
// //     x = Math.Abs(x);

// //     int count = 0;
// //     while (x % 1 != 0) { ++count; x *= 10; }
// //     return count;
// // }

// Console.WriteLine(count);
