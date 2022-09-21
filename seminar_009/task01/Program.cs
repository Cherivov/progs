Console.WriteLine("Введите первый параметр от 1 до 3: ");
int firstParametr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй параметр от 1 до 11: ");
int secondParametr = Convert.ToInt32(Console.ReadLine());

int Ackerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Ackerman(n - 1, 1);
    else
        return Ackerman(n - 1, Ackerman(n, m - 1));
}

if ((firstParametr < 0) || (secondParametr < 0) || (firstParametr > 3) || (secondParametr > 11))
{
    Console.WriteLine("Вы вышли за пределы диапозона");
}
else
{
    int result = Ackerman(firstParametr, secondParametr);
    Console.WriteLine(result);
}