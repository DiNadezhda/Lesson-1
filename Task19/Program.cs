/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

14212 -> нет

12821 -> да

23432 -> да*/

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());




if (number >= 10000 && number < 100000) // проверка на 5-значность
{
    Console.Write($"{number} -> ");
    Console.Write(Palindrome(number) ? "да" : "нет");
}
else Console.WriteLine("Введены некорректные данные");


// метод, сравнивающий симметричные цифры числа
bool Palindrome(int num)
{
    if (num / 10000 == num % 10
        && num / 1000 % 10 == num / 10 % 10) return true;
    else return false;
}

