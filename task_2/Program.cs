﻿/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите два числа и узнаете, какое из них большее.");
Console.WriteLine("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine()); 

if(numberA > numberB)
{
    Console.WriteLine($"Число {numberA} больше {numberB}");
}
else if(numberA < numberB)
{
    Console.WriteLine($"Число {numberB} больше {numberA}");
}
else
    Console.WriteLine($"Числа {numberA} и {numberB} равны");
