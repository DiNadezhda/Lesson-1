/*Задача 49: 
Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.

Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть вот так:
 1 4 49 2
 5 9 2 3
64 4 4 4*/

//Метод, создающий двуменый массив
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

//Метод, возвращающий двумерный массив, в котором
//оба индекса чётные, и заменены эти элементы на их квадраты
void FindEvenIndex(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j];
        }
    }
}

//Вывод двумерного массива в терминал
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("]");
    }
}

int[,] matrix1 = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(matrix1);
Console.WriteLine();
FindEvenIndex(matrix1);
PrintMatrix(matrix1);