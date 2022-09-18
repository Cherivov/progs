// Назовём число «интересным» если его произведение цифр делится на их сумму. 
// Напишите программу, которая заполняет массив на N «интересных» случайных целых чисел. (Каждый эл-т массива должен быть сгенерирован случайно)
int index = 0;
int n = 0;

Console.Write("Введите длину Массива: ");
int L = Convert.ToInt32(Console.ReadLine());

int[] second_array = new int[L];
int[] res_array = new int[L];
for (int i = 0; i < L; i++)
{
    int number = new Random().Next();
    Console.WriteLine(number);

    int length(int number)             //узнаем длину числа
    {
        int num_len = 1;
        while ((number /= 10) >= 1) ++num_len;
        return num_len;
    }


    int a_len = length(number);

    int[] first_array = new int[a_len];

    int[] FillTheArray(int number)      //Заполняем первый массив
    {
        int[] array = new int[a_len];
        while (n < a_len)
        {
            int a = Convert.ToInt32(Math.Pow(10, n + 1));
            int b = Convert.ToInt32(Math.Pow(10, n));
            int digit = Convert.ToInt32((number % a) / b);
            array[index] = digit;
            Console.Write(array[index] + ", ");
            index++; n++;

        }
        return array;
    }

    bool intrestingNumber(int[] a)       // Проверка интересности числа
    {
        int prod = 1;
        int sum = 0;
        for (int i = 0; i < a_len; i++)
        {
            prod = prod * first_array[i];
            sum = sum + first_array[i];
        }
        Console.WriteLine(prod);
        Console.WriteLine(sum);
        if (prod % sum == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    first_array = FillTheArray(number);

    if (intrestingNumber(first_array) == true)
    {
        second_array[i] = number;
        Console.WriteLine("это" + second_array[i]);

    }
    else
    {
        res_array[i] = number;
        Console.WriteLine("это рез" + res_array[i]);
    }

}



