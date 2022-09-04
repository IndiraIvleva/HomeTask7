/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

using static System.Console;
Clear();
WriteLine("Введите размер массива:");
int n = Convert.ToInt32(ReadLine()!);
int[,] array = new int[n, n];
int num = 1;
int i = 0;
int j = 0;

while (num <= n * n)
{
    array[i, j] = num;

    if (i <= j + 1 && i + j < n - 1)
    {
        j++;
    }
    else if (i < j && i + j >= n - 1)
    {
        i++;
    }
    else if (i >= j && i + j > n - 1)
    {
        j--;
    }
    else
    {
        i--;
    }
    num++;
}

PrintArray(array);


void PrintArray(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Write(mass[i, j] < 10 ? $"0{mass[i, j]} " : $"{mass[i, j]} ");
        }
        WriteLine();
    }
}
