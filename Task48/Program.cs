/*Задача 48: 
Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: 
Amn = m+n.
Выведите полученный массив на экран.

m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5*/


int[,] matrixSumInd = CreateMatrixSumIndex(3, 4);
PrintMatrix(matrixSumInd);

//Метод, создающий двумерный массив
int[,] CreateMatrixSumIndex(int rows, int columns)
{
    int[,] matrix = new int[rows, columns]; // 0, 1

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

//Вывод двумерного массива в терминал
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}

