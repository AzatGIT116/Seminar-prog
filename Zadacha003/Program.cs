﻿// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
//       3 -> Среда
//       5 -> Пятница

Console.WriteLine("Введите цифру от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());
Console.Write("День недели ");
if (day == 1)
{
   Console.WriteLine("Понеделник"); 
}
else if (day == 2)
{
    Console.WriteLine("Вторник");
}
else if (day == 3)
{
    Console.WriteLine("Среда");
}
else if (day == 4)
{
    Console.WriteLine("Четверг");
}
else if (day == 5)
{
    Console.WriteLine("Пятница");
}
else if (day == 6)
{
    Console.WriteLine("Суббота");
}
else if (day == 7)
{
    Console.WriteLine("Воскресенье");
}