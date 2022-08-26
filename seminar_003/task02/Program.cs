// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки Аx: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки Аy: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки Аz: ");
int az = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки Bx: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки By: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки Bz: ");
int bz = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));

Console.WriteLine("Расстояние между двумя точками : " + Math.Round(distance, 2));