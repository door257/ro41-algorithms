using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Введите два целых неотрицательных числа a и b: ");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            PrintInputError();
            return;
        }

        string[] parts = input.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length != 2 ||
            !long.TryParse(parts[0], NumberStyles.Integer, CultureInfo.InvariantCulture, out long a) ||
            !long.TryParse(parts[1], NumberStyles.Integer, CultureInfo.InvariantCulture, out long b) ||
            a < 0 || b < 0 || (a == 0 && b == 0))
        {
            PrintInputError();
            return;
        }

        // Алгоритм Евклида — соответствует блок-схеме.
        while (b != 0)
        {
            long r = a % b;
            a = b;
            b = r;
        }

        Console.WriteLine($"НОД = {a}");
    }

    static void PrintInputError()
    {
        Console.WriteLine("Ошибка: введите два целых неотрицательных числа, не равных нулю одновременно.");
    }
}
