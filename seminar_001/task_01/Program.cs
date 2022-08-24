int a, b;
string input;

Console.Write("Введите число №1: ");
input = Console.ReadLine();
a = Int32.Parse(input);

Console.Write("Введите число №2: ");
input = Console.ReadLine();
b = Int32.Parse(input);

if (a>b)
{
    Console.WriteLine("Число №1 которое равно: " + a + " больше, числа №2 которое равно: " + b);    
}
else
{
    Console.WriteLine("Число №2 которое равно: " + b + " больше, числа №1 которое равно: " + a);
}