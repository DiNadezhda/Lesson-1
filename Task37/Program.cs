/*Задача 37: 
Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

int[] array = CreateArrayRndInt(5, 1, 8);
PrintArray(array);
int[] newArray = MultiplicationOfNumbersArray(array);
PrintArray(newArray);


//Метод, создающий массив
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

//Метод, возвращающий новый массив, перемножающий пары элементов в исходном массиве
int[] MultiplicationOfNumbersArray(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 == 1) size += 1;

    int[] resArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        if (i != arr.Length - 1 - i)
            resArr[i] = arr[i] * arr[arr.Length - 1 - i];
        else resArr[i] = arr[i];
    }
    return resArr;
}