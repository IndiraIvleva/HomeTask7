/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using static System.Console;
Clear();

WriteLine("Введите параметры два числа m и n через пробел:");
int[] p = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();


WriteLine($"{GetNumSum(p[0], p[1])}");

int GetNumSum(int m, int n)
{
    if (m == n) return n;
    else return (m > n) ? n + GetNumSum(m, n + 1) : m + GetNumSum(m + 1, n);
}