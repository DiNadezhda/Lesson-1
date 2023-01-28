﻿/*Задача 55: 
Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для
пользователя. */

int matrixRows = 4;
int matrixColumns = 4;

int[,] matrixRndInt = CreateMatrixRndInt(matrixRows, matrixColumns, 1, 9);
PrintMatrix(matrixRndInt);
Console.WriteLine();

if (matrixRows == matrixColumns) PrintMatrix(NewMatrix(matrixRndInt));
else Console.WriteLine("Число строк не равно числу колонок");

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

//Метод заменяет строки на столбцы
int[,] NewMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            newMatrix[i, j] = matrix[j, i];
        }
    }
    return newMatrix;
}

//Метод заменяет строки на столбцы - 2
// int[,] NewMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0)-1; i++)
//     {
//         for (int j = i+1; j < matrix.GetLength(1); j++)
//         {
//             int temp = matrix[i,j];
//             matrix[i,j] = matrix[j,i];
//             matrix[j,i] = temp;
//         }
//     }
//     return matrix;
// }