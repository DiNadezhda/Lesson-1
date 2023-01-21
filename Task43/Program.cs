/*Задача 43. 
Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = СoordinateX(b1, k1, b2, k2);
double y = Math.Round(k1 * x + b1, 1);

Console.WriteLine($"-> ({x}; {y})");


//Метод подсчета координаты X
double СoordinateX(double numB1, double numK1, double numB2, double numK2)
{
    double numX = (numB2 - numB1) / (numK1 - numK2);
    numX = Math.Round(numX, 1);
    return numX;
}

