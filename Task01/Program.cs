// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine ("Введите первое число");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число");
int second_number = Convert.ToInt32(Console.ReadLine());
int square = first_number * first_number;
if (square == second_number)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}