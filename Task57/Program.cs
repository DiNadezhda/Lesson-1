/*Задача 57: 
Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.

Набор данных Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 } 
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза

1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза */

int[,] matrixRndInt = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(matrixRndInt);
Console.WriteLine(String.Empty);

int[] array = MatrixToArray(matrixRndInt);
Array.Sort(array);
PrintArray(array);
Console.WriteLine(String.Empty);

Dictionary(array);

//Метод «Частотный словарь»
void Dictionary(int[] arr)
{
    int count = 1;
    int num = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == num) count++;
        else
        {
            Console.WriteLine($"{num} -> {count}");
            num = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"{num} -> {count}");
}

//Метод переводит двумерный массив в одномерный
int[] MatrixToArray(int[,] matrix)
{
    int[] arr = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[k] = matrix[i, j];
            k++;
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



