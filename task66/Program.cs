// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

int numbers(int n, int m)
{
    if (n == m) return n;
    else return n + numbers(n + 1, m);
}

Console.WriteLine(numbers(1, 10));