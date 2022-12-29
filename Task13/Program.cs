/*Напишите программу, которая 
1. выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)  Console.WriteLine("Третьей цифры нет");
else if (number >= 100 && number < 1000) Console.WriteLine($"Третья цифра -> {ThirdDigit(number)}");
else if (number >= 1000) Console.WriteLine($"Третья цифра -> {ThirdDigit(ToThree(number))}");
    
    
int ToThree (int numM) // numM больше 1000
   {
    while (numM >= 1000) 
    {
        numM = numM / 10;
    }
    return numM; // Возвращаем преобразованное трёхзначное число
   }


int ThirdDigit(int num) // num — трёхзначное число
{
    return num % 10;
}