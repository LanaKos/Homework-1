/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите три числа и узнаете, какое из них максимальное.");

Console.WriteLine("Введите первое число:");
int numberFirst = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите второе число:");
int numberSecond = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите третье число:");
int numberThird = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine($"Максимальное число: {Math.Max(numberFirst, Math.Max(numberSecond, numberThird))}");