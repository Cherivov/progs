int a;
string input;

Console.Write("Введите число: ");
input = Console.ReadLine();
a = Int32.Parse(input);

if (a % 2 == 0)
{
    Console.WriteLine("Число " + a + " четное");
}
else
{
    Console.WriteLine("Число " + a + " нечетное");
}