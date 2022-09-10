// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Рекомендую учесть три возможных случая расположения двух прямых.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
if ((k1 == k2) && (b1 == b2))
{
    Console.WriteLine("Прямые совпадают");
}
else
{
    if (k1 == k2)
    { Console.WriteLine("Прямые паралельны"); }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y1 = k1 * x + b1;
        double y2 = k2 * x + b2;

        Console.WriteLine("Точка пересечения: " + y1 + " , " + y2);
    }
}