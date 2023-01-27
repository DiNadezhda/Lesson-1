/*Задача 53: 
Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.*/

int[,] matrixRndInt = CreateMatrixRndInt(4, 8, 1, 9);
PrintMatrix(matrixRndInt);

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

//Расчёт среднего арифметического каждого столбца массива
double[] ArithmeticMeanOfArrayColumns(int[,] matrix)
{
        double[] arr = new double[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        arr[i] = Math.Round(sum / matrix.GetLength(0), 1);
    }
    return arr;
}