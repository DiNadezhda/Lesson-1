/*Задача 40: 
Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.

Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.*/

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (IsItPositivChecking(number1, number2, number3))
{
    bool result = TriangleInequalityTheorem(number1, number2, number3);
    Console.WriteLine(result ? "Нет" : "Да");
}
else Console.WriteLine("Ошибка ввода числа");

// Console.WriteLine(TriangleInequalityTheorem(number1, number2, number3) ? "да" : "нет");

//Проверка на позитивность числа
bool IsItPositivChecking(int num1, int num2, int num3)
{
    return num1 > 0 && num2 >0 && num3 > 0;
}

//Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.
bool TriangleInequalityTheorem(int num1, int num2, int num3)
{
    int sum1 = num1 + num2;
    int sum2 = num1 + num3;
    int sum3 = num2 + num3;
    return (num1 >= sum3 || num2 >= sum2 || num3 >= sum1);
}