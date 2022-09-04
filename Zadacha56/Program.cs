/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

using MyLib;
using static System.Console;
Clear();

WriteLine("Введите параметры массива m и n");
int m = int.Parse(ReadLine()!);
int n = int.Parse(ReadLine()!);
if (m == n)
{
    WriteLine("Mассив не прямоугольный");
    return;
}
WriteLine();
int[,] array = MyMetods.GetMatrixArray(m,n, 1, 10);
MyMetods.PrintMatrixArray(array);
int[] arr = MyMetods.FindSumInRow(array);
WriteLine("Суммы построчно:");
WriteLine(String.Join(" ", arr));
MyMetods.FindMinRow(arr);