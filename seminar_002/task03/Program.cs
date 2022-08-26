Console.WriteLine("Введите цифру от 1 до 7:");
int digit=int.Parse(Console.ReadLine());

switch(digit)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Не выходной");
        break;
    case 6:
    case 7:
        Console.WriteLine("Выходной");
        break;
    default:
        Console.WriteLine("Я вас не пониаю");
        break;

}