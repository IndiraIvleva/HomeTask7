/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
using MyLib;
using static System.Console;
Clear();


WriteLine("Введите размеры массива: ");
int m = Convert.ToInt32(ReadLine());
int n = Convert.ToInt32(ReadLine());
double[,] Matrix = MyMetods.GetMatrixArray1(m, n);
MyMetods.PrintMatrixArray(Matrix);