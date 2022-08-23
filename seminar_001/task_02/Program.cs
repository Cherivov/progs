int a, b, c;
string input;

Console.Write("Введите число №1: ");
input = Console.ReadLine();
a = Int32.Parse(input);

Console.Write("Введите число №2: ");
input = Console.ReadLine();
b = Int32.Parse(input);

Console.Write("Введите число №3: ");
input = Console.ReadLine();
c = Int32.Parse(input);

int max = a;

if (b>max) max = b;
if (c>max) max = c;
Console.Write("Максимальное число = " + max);