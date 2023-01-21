/*Задача 43. 
Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double x = Math.Round(СoordinateX(b1, k1, b2, k2), 2);

double y = Math.Round(k1 * x + b1, 1);

Console.WriteLine($"-> ({x}; {y})");


//Метод подсчета координаты X
double СoordinateX(int numB1, int numK1, int numB2, int numK2)
{
    double numX = (numB2 - numB1) / (numK1 - numK2);
    // numX = Math.Round(double);
    return numX;
}

