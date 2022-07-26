// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string number(int n, int m)
{
    if (n == m)
    {
        return n.ToString();
    }

    else
    {
        return n.ToString() + " " + number(n += 1, m);
    }
}

Console.WriteLine("Введите начальное число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Числа в заданном вами промежутке");
Console.WriteLine(number(n, m));