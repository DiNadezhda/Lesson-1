/*Задача 66: 
Задайте значения M и N. 
Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите первое число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.Write(" -> ");
if (numberM < numberN) Console.WriteLine(SumNaturalElem (numberM, numberN));
else Console.WriteLine(SumNaturalElem (numberN, numberM));

// Сумма натуральных элементов в промежутке от M до N. Рекурсия
int SumNaturalElem(int numM, int numN)
{
    if (numM == numN) return numM;
    else return numN + SumNaturalElem (numM, numN - 1);
}
