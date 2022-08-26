int start = 1;
int stop = 100000;
// int number = 162;            // Для проверки кода.
int number = new Random().Next(start, stop + 1);
Console.WriteLine("Сгенерированное число: " + number);

if ((number % 7 == 0) & (number % 23 == 0))
{
    Console.WriteLine("Число " + number + " кратно 7 и 23!");
}
else
{
    Console.WriteLine("Число не кратно!");
}