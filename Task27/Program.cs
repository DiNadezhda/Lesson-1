/*Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12*/

Console.Write ("Введите целое число: ");
int number = Convert.ToInt32 (Console.ReadLine());

int sumDigit = SumDigit(number);
Console.WriteLine($"Сумма цифр в числе {number} -> {sumDigit}");

//Метод, выдающий сумму цифр в числе
int SumDigit(int num)
{
    int sum = 0;
    for (int i = 0; i <= 10; i++)
    {
        sum = sum + ( num % 10 );
        num = num / 10;
    }
    return sum;
} 