/*Задача 42: 
Напишите программу, которая будет преобразовывать
десятичное число в двоичное.

45 -> 101101
3 -> 11
2 -> 10*/

Console.WriteLine("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());

string result = ConvertDecToBin(number);
Console.WriteLine($"{number} -> {result}");

//Метод, преобразующий десятичное число в двоичное
string ConvertDecToBin(int num)
{
    string res = string.Empty; //задали пустую строку
    while (num > 0)
    {
        res = num % 2 + res;
        num = num / 2;
    }
    return res;
}