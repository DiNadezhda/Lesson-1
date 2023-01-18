/*Задача 33: 
Задайте массив. 
Напишите программу, которая
определяет, присутствует ли заданное число в массиве.

4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да*/


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

//Метод, проверяющий каждый элемент массива на равенство определенному числу
bool IsExist(int num, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (num == arr[i]) return true;
    }
    return false;
}


Console.Write("Введите целое число "); //console вывод в терминале. write запись без переноса
var number = int.Parse(Console.ReadLine()); // преобразует строку в 32битный int

int[] array = CreateArrayRndInt(8, -8, 8);
PrintArray(array);

Console.WriteLine(IsExist(number, array) == true ? " -> Да" : " -> Нет");