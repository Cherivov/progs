int start = 1;
int stop = 65536;
int digit_third;

int number = new Random().Next(start, stop + 1);
Console.WriteLine("Сгенерированное число: " + number);

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{

    if (number < 1000)
    {
        digit_third = number % 10;
        Console.WriteLine("Третья цифра числа " + number + ": " + digit_third);
    }
    else
    {
        if (number < 10000)
        {
            digit_third = (number % 100) / 10;
            Console.WriteLine("Третья цифра числа " + number + ": " + digit_third);
        }

        else

        {


            digit_third = (number % 1000) / 100;
            Console.WriteLine("Третья цифра числа " + number + ": " + digit_third);

        }
    }
}