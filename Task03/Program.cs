/*Напишите программу, которая будет выдавать
название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница*/

Console.WriteLine("Введите число в диапазоне от 1 до 7:");
string number = Console.ReadLine();
if (number == "1") Console.WriteLine("понедельник");
else if (number == "2") Console.WriteLine("вторник");
else if (number == "3") Console.WriteLine("среда");
else if (number == "4") Console.WriteLine("четверг");
else if (number == "5") Console.WriteLine("пятница");
else if (number == "6") Console.WriteLine("суббота");
else if (number == "7") Console.WriteLine("воскресенье");
else Console.WriteLine("Не бывает такого дня недели");
