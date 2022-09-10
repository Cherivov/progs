// Программа запрашивает натуральное число M, пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Write("Введите количество проверяемых чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < M; i++)
{
    Console.Write("Введите проверяемое число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        count = count + 1;
    }
}
Console.WriteLine($"Количество чисел больше нуля: {count}");