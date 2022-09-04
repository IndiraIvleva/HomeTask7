/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

using MyLib;
using static System.Console;
Clear();

WriteLine("Введите параметры массива m, n, min, max через пробел:");
int[] par = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,] array = MyMetods.GetMatrixArray(par[0], par[1], par[2], par[3]);
WriteLine("Двумерный массив:");
MyMetods.PrintMatrixArray(array);
MyMetods.GetSort(array);
WriteLine();
WriteLine("Упорядоченный массив построчно по убыванию");
MyMetods.PrintMatrixArray(array);