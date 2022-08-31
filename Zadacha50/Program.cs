/* Задача 50. Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

using MyLib;
using static System.Console;
Clear();

WriteLine("Введите параметры массива: ");
int[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,] array = MyMetods.GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
MyMetods.PrintMatrixArray(array);
WriteLine();
int[] rowArray = MyMetods.GetRowArray(array).Select(x => x).ToArray();
WriteLine("Введите искомое число: ");
int n = Convert.ToInt32(ReadLine());
MyMetods.FindElement(rowArray, n);