/*Напишите программу, которая 
1. будет принимать на вход два числа и 
2. выводить, является ли первое число кратным второму. 
3. Если число 1 не кратно числу 2, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно*/

Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int res = Multiplicity(number1, number2);
Console.WriteLine(res == 0 ? "Кратно" : $"Не кратно, остаток от деления {res}");

// if (number1 % number2 == 0) Console.WriteLine("кратно");
// else Console.WriteLine($"не кратно, остаток {number1 % number2}");

int Multiplicity(int num1, int num2)
{
    return num1 % num2;
}