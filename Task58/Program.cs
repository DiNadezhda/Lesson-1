/*Задача 58: 
Задайте две матрицы. 
Напишите программу, которая будет
находить произведение двух матриц. */

int[,] matrix1 = CreateMatrixRndInt(2, 2, 1, 9);
Console.WriteLine("Первая матрица: ");
PrintMatrix(matrix1);
Console.WriteLine();

int[,] matrix2 = CreateMatrixRndInt(2, 2, 1, 9);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(matrix2);
Console.WriteLine();
Console.WriteLine("Результат произведения двух матриц: ");

if (CheckingForEqualityOfColumnsToRows(matrix1, matrix2) == true) PrintMatrix(MatrixMultiplication(matrix1, matrix2));
else Console.WriteLine(" -> Матрицы перемножить невозможно");

//В таком виде программа не работает:
// Console.WriteLine(CheckingForEqualityOfColumnsToRows(matrix1, matrix2) ? PrintMatrix(MatrixMultiplication(matrix1, matrix2)) : " -> Матрицы перемножить невозможно");

// Проверка на равенство числа столбцов матрицы A к числу строк матрицы B
bool CheckingForEqualityOfColumnsToRows(int[,] mat1, int[,] mat2)
{
    int rows2 = mat2.GetUpperBound(0) + 1;    // количество строк mat2
    int columns1 = mat1.GetUpperBound(1) + 1;        // количество столбцов mat1
    return columns1 == rows2;
}

// Умножение матрицы А на матрицу B
int[,] MatrixMultiplication(int[,] mat1, int[,] mat2)
{
    int[,] matRes = new int[mat1.GetLength(0), mat2.GetLength(1)];

    for (int i = 0; i < mat1.GetLength(0); i++)
    {
        for (int j = 0; j < mat2.GetLength(1); j++)
        {
            for (int k = 0; k < mat2.GetLength(0); k++)
            {
                matRes[i, j] += mat1[i, k] * mat2[k, j];
            }
        }
    }
    return matRes;
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