using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество секунд: ");
        string? input = Console.ReadLine();

        if (!long.TryParse(input, NumberStyles.Integer, CultureInfo.InvariantCulture, out long totalSeconds)
            || totalSeconds < 0)
        {
            Console.WriteLine("Ошибка: введите целое неотрицательное число.");
            return;
        }

        long hours = totalSeconds / 3600;
        long minutes = (totalSeconds % 3600) / 60;
        long seconds = totalSeconds % 60;

        Console.WriteLine($"{hours} ч {minutes} мин {seconds} с");
    }
}
