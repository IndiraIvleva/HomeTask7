/*
Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N по убыванию.
M = 1; N = 5. -> ""5,4,3,2,1""
M = 4; N = 8. -> ""8,7,6,5,4""
*/

using static System.Console;
Clear();

WriteLine("Введите параметры два числа m и n через пробел:");
int[] p = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();


WriteLine($"{GetStringNum(p[0], p[1])}");

string GetStringNum(int m, int n)
{
    if (m < n)
    {
        return (n == m) ? $"{m}" : $" {n}" + " " + GetStringNum(n - 1, m);
    }
    else
    {
        return (m == n) ? $"{n}" : $" {m}" + " " + GetStringNum(m - 1, n);
    }
}