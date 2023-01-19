/*Задача 38: 
1. Задайте массив вещественных чисел. 
2. Найдите разницу между максимальным и минимальным элементов массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2*/

//Метод, создающий массив из вещественных чисел
double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    var rnd = new Random(); // var когда в правой части ясно какой тип данных мы используем
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

//Вывод массива в терминал
void PrintArrayDouble(double[] arr)
{
    Console.Write('[');
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}