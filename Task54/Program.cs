/*Задача 54: 
Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
*/
int[,] matrixRndInt = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(matrixRndInt);
Console.WriteLine();

Console.WriteLine("Массив с упорядоченными по убыванию элементами каждой строки: ");
PrintMatrix(SortDescendingRow(matrixRndInt));


//Упорядочивание по убыванию элементов каждой строки двумерного массива
int[,] SortDescendingRow (int[,] matrix)
{
    // int[,] martixSort = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = matrix.GetLength(1)-1; k > j; k--)
            {
                if (matrix[i, k] > matrix[i, k-1])
                {
                    int temp = matrix[i,k];
                    matrix[i, k] = matrix[i, k-1];
                    matrix[i, k-1] = temp;
                }
            }
        }
    }
    return matrix;
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