/*Задача 60: 
Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. 
Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента. */

Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество колонок: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение глубины массива: ");
int field = Convert.ToInt32(Console.ReadLine());

int[,,] matrix3D = CreateMatrix3DInt(row, column, field);

if (ValueLimit(row, column, field) == true) Print3DMatrixAndIndex(matrix3D);
else Console.WriteLine(" -> Превышение размера матрицы. Введите меньшее значение. ");

// Console.WriteLine(ValueLimit(row, column, field) ? Print3DMatrixAndIndex(matrix3D) : " -> Превышение размера матрицы.");

// Проверка на выход за пределы массива
bool ValueLimit(int rows, int columns, int fields)
{
    return rows <= 30 && columns <= 30 && fields <= 30;
}

//Метод, создающий трехмерный массив 
//из неповторяющихся двузначных чисел
int[,,] CreateMatrix3DInt(int rows, int columns, int fields)
{
    int[,,] matrix = new int[rows, columns, fields];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = i + j + k + 10;
            }
        }
    }
    return matrix;
}

//Вывод трёхмерного массива с индексами
void Print3DMatrixAndIndex(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // Console.Write();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"[{i}, {j}, {k}] {+ matrix[i,j,k], 3}  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}