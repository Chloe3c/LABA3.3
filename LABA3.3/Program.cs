using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите количество членов (n):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("введите значение x:");
        double x = double.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            double term = (1 + 2 * (i - 1)) * Math.Pow((x / 2), i) / Factorial(i);
            sum += term;
        }
        Console.WriteLine("сумма: " + sum);
    }
    static double Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }
}
