/*Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/


int[] array = new int[8]; // 0.1.2.3.4.5.6.7

FillArray (array);
PrintArray(array);

//Метод создания рандомного массива от 0 до 1
void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
}

//Метод вывода на печать массива
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}


// System.Console.WriteLine(array[0]); //Обратиться к определенному элементу массива
// array[0] = 235; //Присвоить значение определенному индексу массива
// System.Console.WriteLine (array[2]); //Посмотреть значение определенного индекса массива

// Возможные варианты инициализации массива в С#:

// int [] array1 = new int [8]{2,3,4,5,6,12,11,8};
// int [] array2 = new int {2,3,4,5,6,12,11,8};
// int [] array3 = {2,3,4,5,6,12,11,8};

// Все элементы массива заполнятся 2:

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = 2;
// }
