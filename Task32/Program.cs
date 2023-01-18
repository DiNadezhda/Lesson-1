/*Задача 32: 
Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

//Метод, задающий массив
int[] CreateArrayRndInt(int size, int min, int max) // сигнатура метода
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

//Метод, выводящий массив в []
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

//Метод, меняющий - на + и + на - в элементах массива
void ReversArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}


int[] array = CreateArrayRndInt(4, -9, 9); //создание массива
PrintArray(array); //вывод изначального массива

ReversArray(array); //"переворот" массива
PrintArray(array); //вывод "перевернутого" массива
