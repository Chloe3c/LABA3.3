double Factorial(int n)
{
    return n == 0 ? 1 : n * Factorial(n - 1);
}

Console.WriteLine("Введите количество членов (n):");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение x:");
double x = double.Parse(Console.ReadLine());

double sum = 0;
for (int i = 1; i <= n; i++)
{
    double term = (1 + 2 * (i - 1)) * Math.Pow((x / 2), i) / Factorial(i);
    sum += term;
}

Console.WriteLine("Сумма: " + sum
