/*Задача 68: 
Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29 */

Console.Write("Введите первое число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(String.Empty);
Console.WriteLine($" -> A({numberM},{numberN}) = {Ackerman(numberM, numberN)}");

int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m != 0) && (n == 0)) return Ackerman(m - 1, 1);
    else return Ackerman(m - 1, Ackerman(m, n - 1));
}