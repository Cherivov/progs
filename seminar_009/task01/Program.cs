Console.WriteLine("Введите два параметра больше нуля: ");
int firstParametr = Convert.ToInt32(Console.ReadLine());
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

if ((firstParametr < 0) || (secondParametr < 0))
{
    Console.WriteLine("Вы ввели отрицательное число");
}
else
{
    int result = Ackerman(firstParametr, secondParametr);
    Console.WriteLine(result);
}