using System;

int[] numbers = { 0, 7, 12345, 1000 };

foreach (int n in numbers)
{
    Console.WriteLine($"DigitSum({n}) = {Rec.DigitSum(n)}");
}

(int X, int N)[] powers =
{
    (2, 0),
    (2, 10),
    (5, 3),
    (7, 1)
};

foreach (var item in powers)
{
    Console.WriteLine($"Pow({item.X}, {item.N}) = {Rec.Pow(item.X, item.N)}");
}

static class Rec
{
    public static int DigitSum(int n)
    {
        // Базовый случай: у однозначного числа сумма цифр равна самому числу.
        if (n < 10)
            return n;

        return n % 10 + DigitSum(n / 10);
    }

    public static long Pow(int x, int n)
    {
        // Базовый случай: любое число в нулевой степени равно 1.
        if (n == 0)
            return 1;

        return x * Pow(x, n - 1);
    }
}
