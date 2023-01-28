/*Задача 62: Заполните спирально массив 4 на 4. */

int[,] matrixSpiral = CreateSpiralMatrix(4);
PrintMatrix(matrixSpiral);

//Метод создающий спиральную квадратную матрицу
int[,] CreateSpiralMatrix(int n)
{
    int[,] matrix = new int[n, n];
    int i = 0;
    int j = 0;

    for (int temp = 1; temp <= matrix.GetLength(0) * matrix.GetLength(1); temp++)
    {
        matrix[i, j] = temp;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1) j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1) i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1) j--;
        else i--;
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