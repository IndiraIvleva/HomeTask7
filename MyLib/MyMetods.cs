using System;
using static System.Console;
namespace MyLib;
public class MyMetods
{

    ///<summary>
    ///Matrix1
    ///</summary>
    public static int[,] GetMatrixArray(int rows, int colums, int minValue, int maxValue)
    {
        int[,] result = new int[rows, colums];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                result[i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }
        return result;
    }


    ///<summary>
    ///MatrixVesch
    ///</summary>
    public static double[,] GetMatrixArray1(int rows, int colums)
    {
        double[,] result = new double[rows, colums];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                result[i, j] = new Random().NextDouble() + new Random().Next(-10, 10); ;
            }
        }
        return result;
    }

    ///<summary>
    ///MatrixDouble
    ///</summary>
    public static double[,] GetMatrixDouble(int rows, int colums, int minValue, int maxValue)
    {
        double[,] result = new double[rows, colums];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                result[i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }
        return result;
    }


    public static void PrintMatrixArray(int[,] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Write($"{inArray[i, j]} ");
            }
            WriteLine();

        }
    }

    public static void PrintMatrixArray(double[,] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Write($"{inArray[i, j]:f1} ");
            }
            WriteLine();

        }
    }


    public static void PrintMatrixDouble(double[,] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Write($"{inArray[i, j]} ");
            }
            WriteLine();

        }
    }


    public static int[] GetRowArray(int[,] inArray)
    {
        int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];
        int k = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                result[k] = inArray[i, j];
                k++;
            }
        }
        return result;
    }


    public static void FindElement(int[] inArray, int find)
    {
        for (int i = 0; i < inArray.Length; i++)
        {
            if (inArray[i] == find)
            {
                WriteLine($"Число {find} в массиве есть");
                return;
            }
        }
        WriteLine($"Число {find} в массиве отсутствует");
    }

    public static void FindSum(double[,] array)
    {
        double[] sum = new double[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum[j] += array[i, j];

            }
            sum[j] = sum[j] / array.GetLength(0);
            Write($"{sum[j]:f1}; ");

        }
    }

    public static void GetSort(int[,] mass)
    {
        for (int i = 0; i < mass.GetLength(0); i++)
        {
            for (int j = 0; j < mass.GetLength(1); j++)
            {
                for (int k = j + 1; k < mass.GetLength(1); k++)
                {
                    if (mass[i, j] < mass[i, k])
                    {
                        int temp = mass[i, j];
                        mass[i, j] = mass[i, k];
                        mass[i, k] = temp;
                    }
                }
            }
        }
    }

    public static int[] FindSumInRow(int[,] array)
    {
        int[] result = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
            result[i] = sum;
        }
        return result;
    }

    public static void FindMinRow(int[] array)
    {
        int min = array[0];
        int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (min >= array[i])
                {
                min = array[i];
                index = i+1;
                }
            }
        WriteLine($"Номер строки с наименьшей суммой элементов: {index}");
    }

public static int[,] MultArray(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return result;
}

}
