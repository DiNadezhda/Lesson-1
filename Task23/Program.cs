/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125*/

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) TableСube(number);
else Console.WriteLine("Некорректные данные");


void TableСube(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count, 4} | {Math.Pow(count, 3), 6}");
        count++;
    }
}