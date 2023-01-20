/*Задача 39: 
Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

int[] array = CreateArrayRndInt(5, 1, 8);
PrintArray(array);
ReverseArray(array);
PrintArray(array);
Array.Reverse(array);
PrintArray(array);
ReverseArrayVerision2(array);
PrintArray(array);

//Метод, сздающий массив
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    var rnd = new Random(); // var когда в правой части ясно какой тип данных мы используем
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

//Вывод массива в терминал
void PrintArray(int[] arr)
{
    Console.Write('[');
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

//Метод, переворачивающий одномерный массив
// Array.Reverse(array)
// [1 2 3 4 5] -> [5 4 3 2 1]
void ReverseArray (int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i]; 
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

//Метод, переворачивающий одномерный массив (Microsoft)
void ReverseArrayVerision2 (int[] arr)
{
    int index1 = 0;
    int index2 = arr.Length - 1;

    while (index1 < index2)
    {
        int obj = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = obj;
        index1++;
        index2--;
    }
}