/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

using MyLib;
using static System.Console;
Clear();
WriteLine("Введите параметры массива через пробел:");
int[] par = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
double[,] array = MyMetods.GetMatrixDouble(par[0], par[1], par[2], par[3]);
WriteLine("Двумерный массив:");
MyMetods.PrintMatrixDouble(array);
WriteLine("Среднее арифметическое элементов в каждом столбце:");
MyMetods.FindSum(array);