using ArrayAlgos;

int[][] testArrays =
{
    Array.Empty<int>(),
    new[] { 5 },
    new[] { 1, 2, 3, 4, 5 },
    new[] { 5, 4, 3, 2, 1 },
    new[] { 3, 1, 3, 2, 3 }
};

Console.WriteLine("Проверка BubbleSort:");
foreach (int[] testArray in testArrays)
{
    int[] a = (int[])testArray.Clone();

    Console.WriteLine($"До: {FormatArray(a)}");
    Console.WriteLine($"IsSorted до сортировки: {ArrayAlgos.IsSorted(a)}");

    int comparisons = ArrayAlgos.BubbleSort(a);

    Console.WriteLine($"После: {FormatArray(a)}");
    Console.WriteLine($"IsSorted после сортировки: {ArrayAlgos.IsSorted(a)}");
    Console.WriteLine($"Число сравнений: {comparisons}");
    Console.WriteLine();
}

// Для отсортированного массива из 1000 элементов должно быть ровно 999 сравнений.
int[] sorted1000 = new int[1000];
for (int i = 0; i < sorted1000.Length; i++)
{
    sorted1000[i] = i;
}

int comparisons1000 = ArrayAlgos.BubbleSort(sorted1000);
Console.WriteLine($"Сравнений на отсортированном массиве из 1000 элементов: {comparisons1000}");
Console.WriteLine($"Ожидается 999: {comparisons1000 == 999}");
Console.WriteLine();

int[] sortedA = { 1, 2, 2, 2, 5, 7 };
int[] values = { 2, 1, 7, 3, 9 };
int[] expected = { 3, 1, 1, 0, 0 };

Console.WriteLine("Проверка CountOccurrences:");
for (int i = 0; i < values.Length; i++)
{
    int actual = ArrayAlgos.CountOccurrences(sortedA, values[i]);
    Console.WriteLine($"x = {values[i]}: получено {actual}, ожидается {expected[i]}");
}

static string FormatArray(int[] a)
{
    return "{" + string.Join(", ", a) + "}";
}
