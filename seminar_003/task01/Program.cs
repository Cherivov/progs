// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Число хранить в типе данных int, решать с помощью арифметических операций (не рассматривая число как тип данных string)
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int digit_first = (number % 100000) / 10000;
int digit_second = (number % 10000) / 1000;
int digit_third = (number % 1000) / 100;
int digit_fourth = (number % 100) / 10;
int digit_fifth = number % 10;
// Console.WriteLine(digit_first);
// Console.WriteLine(digit_second);
// Console.WriteLine(digit_third);
// Console.WriteLine(digit_fourth);
// Console.WriteLine(digit_fifth);

if ((digit_first == digit_fifth) && (digit_second == digit_fourth))
{
    Console.WriteLine("Ура, число: " + number + " является полиндромом");
}
else
{
    Console.WriteLine("Увы, число: " + number + " не является полиндромом");
}