/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

using MyLib;
using static System.Console;
Clear();

WriteLine("Введите размеры матриц a1, b1, a2, b2 через пробел:");
int[] p = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
if (p[0] != p[3])
{
    WriteLine("Умножение невозможно: кол-во строк матрицы А не равно кол-ву столбцов матрицы В");
    return;
}
WriteLine("Матрица A");
int[,] Matrix1 = MyMetods.GetMatrixArray(p[0], p[1], 1, 5);
MyMetods.PrintMatrixArray(Matrix1);
WriteLine("Матрица B");
int[,] Matrix2 = MyMetods.GetMatrixArray(p[2], p[3], 1, 5);
MyMetods.PrintMatrixArray(Matrix2);
WriteLine("Умножение матриц А на В");
int[,] MultMatrix = MyMetods.MultArray(Matrix1, Matrix2);
MyMetods.PrintMatrixArray(MultMatrix);