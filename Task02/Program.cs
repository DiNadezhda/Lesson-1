/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/


Console.WriteLine("Введите первое число");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int second_number = Convert.ToInt32(Console.ReadLine());
if (first_number>=second_number) Console.WriteLine($"Число {first_number} максимальное");
else Console.WriteLine($"Число {second_number} больше числа {first_number}");
