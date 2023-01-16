/*Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine ("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

//Проверка на натуральность числа B
if (numberB > 0) Console.WriteLine($"-> {Exponentiation (numberA, numberB)}");
else
{
    numberB = numberB * -1;
    Console.WriteLine($"-> {Exponentiation (numberA, numberB)}");
}

//Метод возведения в степень
int Exponentiation (int numA, int numB)
{
    int exp = 1;
    for (int i = 1; i <= numB; i++)
    { 
        checked // проверка на переполнение
        {
            exp = exp * numA;
        }
    }
    return exp;
  }