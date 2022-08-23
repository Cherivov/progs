int a, b;
string input;

Console.Write("Введите число №1: ");
input = Console.ReadLine();
a = Int32.Parse(input);

Console.Write("Введите число №2: ");
input = Console.ReadLine();
b = Int32.Parse(input);

int max = 0;

if (a>b)
{
    max = a;
}
else
{
    max = b;
}
Console.Write("Max = " + max);