namespace ArrayAlgos;

public static class ArrayAlgos
{
    public static bool IsSorted(int[] a)
    {
        ArgumentNullException.ThrowIfNull(a);

        for (int i = 1; i < a.Length; i++)
        {
            if (a[i - 1] > a[i])
            {
                return false;
            }
        }

        return true;
    }

    public static int BubbleSort(int[] a)
    {
        ArgumentNullException.ThrowIfNull(a);

        int comparisons = 0;

        for (int i = 0; i < a.Length - 1; i++)
        {
            bool swapped = false;

            for (int j = 0; j < a.Length - 1 - i; j++)
            {
                comparisons++;

                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    swapped = true;
                }
            }

            // Если за проход не было обменов, массив уже отсортирован.
            if (!swapped)
            {
                break;
            }
        }

        return comparisons;
    }

    public static int CountOccurrences(int[] sortedA, int x)
    {
        ArgumentNullException.ThrowIfNull(sortedA);

        int first = LowerBound(sortedA, x);
        int afterLast = UpperBound(sortedA, x);

        return afterLast - first;
    }

    // Первый индекс элемента, который >= x.
    private static int LowerBound(int[] a, int x)
    {
        int lo = 0;
        int hi = a.Length;

        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;

            if (a[mid] < x)
            {
                lo = mid + 1;
            }
            else
            {
                hi = mid;
            }
        }

        return lo;
    }

    // Первый индекс элемента, который > x.
    private static int UpperBound(int[] a, int x)
    {
        int lo = 0;
        int hi = a.Length;

        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;

            if (a[mid] <= x)
            {
                lo = mid + 1;
            }
            else
            {
                hi = mid;
            }
        }

        return lo;
    }
}
