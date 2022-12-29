/*Напишите программу, которая
1. принимает на вход координаты двух точек и
2. находит расстояние между ними в 2D
пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21*/

//double d = Math.Sqrt(num) // корень 

// Math.Pow(2, 2);
// double d = Math.Sqrt(355); // квадрат

// double num = 5.099873456;
// double numRound = Math.Round(num, 2, MidpointRounding.ToZero);
// Console.WriteLine(numRound); // округление

Console.WriteLine("Введите координаты двух точек: ");
Console.WriteLine("Ax: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ay: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bx: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("By: ");
int by = Convert.ToInt32(Console.ReadLine());

double ourDistance = Math.Round(Distance(ax, ay, bx, by), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками A и B равно -> {ourDistance}");



double Distance (int x1, int y1, int x2, int y2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return distance;
}