/*Задача 50: 
Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 

1, 7 -> такого элемента
в массиве нет */

Console.WriteLine("Введите i-позицию элемента: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите j-позицию элемента: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int numRows = 4;
int numColumns = 4;
int[,] matrixRndInt = CreateMatrixRndInt(numRows, numColumns, 1, 99);
PrintMatrix(matrixRndInt);

Console.WriteLine();

Console.WriteLine(RangeCheckMatrix(numberM, numberN, numRows, numColumns) == true ? matrixRndInt[numberM, numberN] : " -> Такого элемента в массиве нет");

// if (RangeCheckMatrix(numberM, numberN, numRows, numColumns)) 
// System.Console.WriteLine(matrixRndInt[numberM, numberN]);
// else Console.WriteLine("Такого элемента в массиве нет");

//Метод, создающий двумерный массив
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}

//Проверка на попадание ячейки в массив
bool RangeCheckMatrix(int m, int n, int i, int j)
{
    return m >= 0 && m < i && 
        n >= 0 && n < j;
}

// System.Console.WriteLine(array[0]); //Обратиться к определенному элементу массива
// Console.WriteLine(res == 0 ? "Кратно" : $"Не кратно, остаток от деления {res}");

