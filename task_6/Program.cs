/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число и узнаете, является ли оно чётным.");

Console.WriteLine("Введите первое число:");
int numberFirst = Convert.ToInt32(Console.ReadLine()); 

if(numberFirst % 2 == 0)
{
    Console.WriteLine("Число четное (делится на два).");
}
else
{
    Console.WriteLine("Число нечетное.");
}
