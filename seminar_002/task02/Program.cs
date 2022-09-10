Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Какую цифру числа вывести на экран?");
int pos = Convert.ToInt32(Console.ReadLine());

int length(int number)
{
    int len = 1;
    while ((number /= 10) >= 1) ++len;
    return len;
}
int n = length(number) - pos;

int a = Convert.ToInt32(Math.Pow(10, n + 1));
int b = Convert.ToInt32(Math.Pow(10, n));
int digit = Convert.ToInt32((number % a) / b);

switch (pos)
{
    case 0:
        Console.WriteLine("Нулевого числа не существует");
        break;
    case 1:
        Console.WriteLine("Первая цифра числа " + number + " будет " + digit);
        break;
    case 2:
        Console.WriteLine("Вторая цифра числа " + number + " будет " + digit);
        break;
    case 3:
        Console.WriteLine("Третья цифра числа " + number + " будет " + digit);
        break;
    case 4:
        Console.WriteLine("Четвертая цифра числа " + number + " будет " + digit);
        break;
    case 5:
        Console.WriteLine("Пятая цифра числа " + number + " будет " + digit);
        break;
    case 6:
        Console.WriteLine("Шестая цифра числа " + number + " будет " + digit);
        break;
    case 7:
        Console.WriteLine("Седьмая цифра числа " + number + " будет " + digit);
        break;
    case 8:
        Console.WriteLine("Восьмая цифра числа " + number + " будет " + digit);
        break;
    case 9:
        Console.WriteLine("Девятая цифра числа " + number + " будет " + digit);
        break;
}