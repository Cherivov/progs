// Найдите сумму произведений пар чисел в одномерном целочисленном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Если кол-во элементов нечетное, 
// то элемент посередине не учитывать. Результат сложения вывести на экран.
// 1, 3, 8, 3, 2 -> 11
// 8, 3, 4, 2 -> 28

Console.Write("Введите длину массива: ");
int L = Convert.ToInt32(Console.ReadLine());
int[] array = new int[L];

for (int i = 0; i < L; i++)
{
    int number = new Random().Next(1, 10);
    array[i] = number;
    Console.WriteLine(array[i]);
}

int sum = 0;
for (int i = 0; i < array.Length - (i + 1); i++)
{
    int prod = array[i] * array[array.Length - (i + 1)];
    sum = sum + prod;
}

Console.WriteLine($"Сумма произведений пар чисел: {sum}");