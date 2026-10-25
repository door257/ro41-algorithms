using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое неотрицательное число: ");
        string? input = Console.ReadLine();

        if (!long.TryParse(input, NumberStyles.Integer, CultureInfo.InvariantCulture, out long n)
            || n < 0)
        {
            Console.WriteLine("Ошибка: введите целое неотрицательное число.");
            return;
        }

        long sum = 0;
        int count = 0;

        do
        {
            long digit = n % 10;
            sum += digit;
            count++;
            n /= 10;
        }
        while (n > 0);

        Console.WriteLine($"Количество цифр: {count}");
        Console.WriteLine($"Сумма цифр: {sum}");
    }
}
