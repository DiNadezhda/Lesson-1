/*Задача 41: 
Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Сколько чисел вы будете вводить? ");
int m = Convert.ToInt32(Console.ReadLine());

int[] array = EnteringNumbers(m);
PrintArray(array);
Console.Write($" -> {SumPositiveElements(array)}");


// Метод для пользовательского ввода чисел
int[] EnteringNumbers(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} число:  ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

//Вывод массива в терминал
void PrintArray(int[] arr)
{
    // Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    // Console.WriteLine("]");
}

// Метод, подсчитывающий количество положительных чисел в массиве
int SumPositiveElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum++;
    }
    return sum;
}




// char числе будете вводить

// метод ввода отдельных данных
// числа сохраняются в массив

// string stp = "числа";
// string[] strArr = str.Split(','); // получили массив из введенных элементов
//  ConvertToAll //конвертирует в другой тип
