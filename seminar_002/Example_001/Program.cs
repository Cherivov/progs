int start = 100;
int stop = 999;

int number = new Random().Next(start, stop + 1);
int digit_second = (number % 100) / 10;

Console.WriteLine("Сгенерированное число: " + number);
Console.WriteLine("Вторая цифра числа " + number + ": " + digit_second);
