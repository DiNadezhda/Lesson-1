﻿/*Напишите программу, которая 
1. принимает на вход трёхзначное число и 
2. на выходе показывает вторую цифру этого числа. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number > 99 && number < 1000) || (number < -99 && number > -1000))
{
    int number1 = number / 10;
    int result = number1 % 10;
    Console.WriteLine($"Вторая цифра этого числа -> {result}");
}
else     Console.WriteLine("Это не трёхзначное число");