/*Напишите программу, которая задаёт
массив из 8 элементов, заполненный
псевдослучайными числами и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.WriteLine("Введите минимальное число массива");
int minNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива");
int maxNumber = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(8, minNumber, maxNumber);
PrintArray(array, 8);

//Метод создания рандомного массива
int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

//Метод вывода на печать массива в квадратных скобках
void PrintArray(int[] arr, int size)
{
    //Вывод массива через запятую (левая часть задания)
    for (int i = 0; i < size-1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[size - 1] + " -> ");

    //Вывод массива в квадратных скобках, через запятую (правая часть задания)
    Console.Write("[");
    for (int i = 0; i < size - 1; i++)
    {
        Console.Write(arr[i] + ", "); 
    }
    Console.Write(arr[size - 1] + "]");
}