/*Задача 38: 
1. Задайте массив вещественных чисел. 
2. Найдите разницу между максимальным и минимальным элементами массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2*/


double[] array = CreateArrayRndDouble(5, 1, 99);
PrintArrayDouble(array);

double maxElemArray = MaxElemArray(array);
double minElemArray = MinElemArray(array);
Console.WriteLine($" -> {maxElemArray - minElemArray}");

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
        if (i < arr.Length - 1) Console.Write(arr[i] + "; ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

//Поиск максимального элемента массива
double MaxElemArray(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

//Поиск минимального элемента массива
double MinElemArray(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}