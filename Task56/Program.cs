/*Задача 56: 
Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей 
суммой элементов. */

int[,] matrixRndInt = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(matrixRndInt);
Console.WriteLine();

Console.WriteLine("Сумма элементов построчно: ");
int[] sumOfElemInRow = SumOfElemInRow(matrixRndInt);
PrintArray(sumOfElemInRow);

Console.WriteLine();
Console.Write("Строка с наименьшей суммой элементов -> ");
Console.WriteLine(IndexMinArrayElement(sumOfElemInRow));



//Нахождение индекса наименьшего элемента массива
int IndexMinArrayElement (int[] arr)
{
    int min = arr[0];
    int k = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) 
        {
            min = arr[i];
            k = i+1;
        }
    }
    return k;
}

//Нахождение суммы элементов построчно
int[] SumOfElemInRow(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[i] += matrix[i, j];
        }
    }
    return arr;
}

//Метод, создающий двумерный массив
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

//Вывод двумерного массива в терминал
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // Console.Write();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}");
            else Console.Write($"{matrix[i, j],3}  ");
        }
        Console.WriteLine();
    }
}

//Вывод одномерного массива в терминал
void PrintArray(int[] arr)
{
    // Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + "; ");
        else Console.Write(arr[i]);
    }
    // Console.WriteLine("]");
}
