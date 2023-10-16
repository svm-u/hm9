/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1" N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
/*
Console.Clear();
string f(int n)
{
    if (n == 1)
        return "1";
    return $"{n}, " + f(n - 1);
}

Console.Clear();
Console.Write("Введите число: "); 
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));
*/
/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30      4 5 6 7 8
*/
/*
int f(int m, int n)
{
    if (m == n)
        return m;
    return f(m+1, n) + m;
}

Console.Clear();
Console.Write("Введите число: "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: "); 
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(m, n));
*/
/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
/*
Console.Clear();
int f(int m, int n)
{
    if (m == 0)
        return n+1;
    if (m > 0 && n==0)
        return f(m-1, 1);
    if (m > 0 && n > 0)
        return f(m-1, f(m, n-1));
    return m;
}

Console.Clear();
Console.Write("Введите число: "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: "); 
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(m, n));
*/
