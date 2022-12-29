/*Напишите программу, которая 
1. принимает на вход координаты двух точек и 
2. находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Введите координаты двух точек: ");
Console.WriteLine("Ax: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ay: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Az: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bx: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("By: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bz: ");
int bz = Convert.ToInt32(Console.ReadLine());

double ourDistance3D = Math.Round(Distance3D(ax, ay, az, bx, by, bz), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками A и B равно -> {ourDistance3D}");



double Distance3D (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return distance;
}