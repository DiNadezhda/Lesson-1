/*Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

string result = ConvertDecToBin(number);
Console.WriteLine($"Если N = {number} -> {result}");

//Метод Фибоначчи (без использования рекурсии)