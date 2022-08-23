int a, count;
string input;

Console.Write("Введите число: ");
input = Console.ReadLine();
a = Int32.Parse(input);

count = 1;

while (count <= a)
{
    if (count % 2 == 0)
    {
        Console.Write(count + ", ");
    }
    count = count + 1;
}