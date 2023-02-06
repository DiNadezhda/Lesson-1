/*Задача 69: 
Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.

A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

Console.Write("Введите первое число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB > 0)
{
    Console.WriteLine(MathPow(numberA, numberB));
}
else Console.WriteLine("Ошибка ввода степени");

// Возведение в степень. Рекурсия
int MathPow(int num, int degree)
{
    if (degree == 0) return 1;
    else return num * MathPow(num, degree - 1);
}