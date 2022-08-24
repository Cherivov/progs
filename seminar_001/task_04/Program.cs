int a, count;
string input;

Console.Write("Введите число: ");
input = Console.ReadLine();
a = Int32.Parse(input);

count = 1;

while (count <= a)
// Первый вариант:
// {
//     if (count % 2 == 0)
//     {
//         Console.Write(count + ", ");
//     }
//     count = count + 1;
// }

// Вариант с исправлением.
{
    if (count % 2 == 0)
    {
        if (count == a || count == a - 1) Console.Write(count);
        else Console.Write(count + ", ");
        
    }
    count = count + 1;
}