using System;

static class Order
{
    public static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    public static void Sort3(ref int a, ref int b, ref int c)
    {
        if (a > b)
            Swap(ref a, ref b);

        if (b > c)
            Swap(ref b, ref c);

        if (a > b)
            Swap(ref a, ref b);
    }
}

class Program
{
    static void Main()
    {
        Test(3, 1, 2);
        Test(1, 2, 3);
        Test(3, 2, 1);
        Test(2, 2, 1);
        Test(5, 5, 5);
    }

    static void Test(int x, int y, int z)
    {
        int a = x;
        int b = y;
        int c = z;

        Order.Sort3(ref a, ref b, ref c);

        Console.WriteLine($"{x} {y} {z} -> {a} {b} {c}");
    }
}
