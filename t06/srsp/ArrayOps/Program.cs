using System;

static class ArrayOps
{
    public static int Sum(int[] a)
    {
        ArgumentNullException.ThrowIfNull(a);

        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }

        return sum;
    }

    public static int IndexOfMin(int[] a)
    {
        ArgumentNullException.ThrowIfNull(a);

        if (a.Length == 0)
        {
            throw new ArgumentException("Массив не должен быть пустым.", nameof(a));
        }

        int min = a[0];
        int minIndex = 0;

        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] < min)
            {
                min = a[i];
                minIndex = i;
            }
        }

        return minIndex;
    }

    public static int CountGreater(int[] a, int x)
    {
        ArgumentNullException.ThrowIfNull(a);

        int count = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > x)
            {
                count++;
            }
        }

        return count;
    }

    public static void Reverse(int[] a)
    {
        ArgumentNullException.ThrowIfNull(a);

        int left = 0;
        int right = a.Length - 1;

        while (left < right)
        {
            int temp = a[left];
            a[left] = a[right];
            a[right] = temp;

            left++;
            right--;
        }
    }
}

class Program
{
    static void Main()
    {
        int[][] testArrays =
        {
            new int[] { 4, 1, 7, 3, 9 },
            new int[] { 5 },
            new int[] { -2, -7, -4 },
            new int[] { 2, 2, 2 }
        };

        const int x = 2;

        foreach (int[] testArray in testArrays)
        {
            int[] a = (int[])testArray.Clone();

            Console.WriteLine($"Исходный массив: [{string.Join(", ", a)}]");
            Console.WriteLine($"Сумма: {ArrayOps.Sum(a)}");
            Console.WriteLine($"Индекс первого минимума: {ArrayOps.IndexOfMin(a)}");
            Console.WriteLine($"Количество элементов больше {x}: {ArrayOps.CountGreater(a, x)}");

            ArrayOps.Reverse(a);
            Console.WriteLine($"После Reverse: [{string.Join(", ", a)}]");
            Console.WriteLine();
        }
    }
}
