/*Задача 31: 
1. Задайте массив из 12 элементов, 
2. заполненный случайными числами из промежутка [-9, 9]. 
3. Найдите сумму отрицательных и положительных элементов массива.

Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20.*/

//Метод, задающий массив
int[] CreateArrayRndInt(int size, int min, int max) // сигнатура метода
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

//Метод, выводящий массив в []
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

//Метод, возвращающий сумму положительных элементов массива
int GetSumPositivElem(int[] arr)
{
    int sum =0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum +=arr[i];
    }
    return sum;
}

//Метод, возвращающий сумму отрицательных элементов массива
int GetSumNegativElem(int[] arr)
{
    int sum =0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum +=arr[i];
    }
    return sum;
}


int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);

int sumPositive = GetSumPositivElem(array);
int sumNegative = GetSumNegativElem(array);

Console.WriteLine($"Сумма положительных элементов = {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegative}");


//Метод, возвращающий одновременно сумму отрицательных и положительных элментов массива

// int[] GetSumPositiveNegativeElem(int[] arr)
// {
//     int sumNeg = 0;
//     int sumPos = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) sumPos += arr[i];
//         else if (arr[i] < 0) sumNeg += arr[i];
//     }
//     return new[]{sumPos, sumNeg};
// }
// //Вызов метода
// int[] sumPositiveNegative = GetSumPositiveNegativeElem(array);
// Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegative[0]}");
// Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegative[1]}");