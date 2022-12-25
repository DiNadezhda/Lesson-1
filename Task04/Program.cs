/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите первое число");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int second_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int third_number = Convert.ToInt32(Console.ReadLine());

int max = first_number;

if (second_number > max) max = second_number;
if (third_number > max) max = third_number;

Console.WriteLine($"Максимальное из этих чисел {max}");
