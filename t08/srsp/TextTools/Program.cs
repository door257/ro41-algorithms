using System;
using System.Text;

static class TextTools
{
    public static int CountWords(string s)
    {
        int count = 0;
        bool inWord = false;

        foreach (char c in s)
        {
            if (char.IsWhiteSpace(c))
                inWord = false;
            else if (!inWord)
            {
                count++;
                inWord = true;
            }
        }

        return count;
    }

    public static bool IsPalindrome(string s)
    {
        StringBuilder text = new StringBuilder();

        foreach (char c in s)
            if (!char.IsWhiteSpace(c))
                text.Append(char.ToUpperInvariant(c));

        int left = 0;
        int right = text.Length - 1;

        while (left < right)
        {
            if (text[left] != text[right])
                return false;

            left++;
            right--;
        }

        return true;
    }

    public static string Initials(string fullName)
    {
        StringBuilder result = new StringBuilder();
        bool beginningOfWord = true;

        foreach (char c in fullName)
        {
            if (char.IsWhiteSpace(c))
                beginningOfWord = true;
            else if (beginningOfWord)
            {
                if (result.Length > 0)
                    result.Append(' ');

                result.Append(char.ToUpperInvariant(c));
                result.Append('.');
                beginningOfWord = false;
            }
        }

        return result.ToString();
    }

    public static string Repeat(string s, int n)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < n; i++)
            result.Append(s);

        return result.ToString();
    }
}

class Program
{
    static void Check<T>(string method, string input, T expected, T actual)
    {
        string status = Equals(expected, actual) ? "OK" : "FAIL";
        Console.WriteLine(
            $"{method,-15} Вход: [{input}] | Ожидалось: [{expected}] | " +
            $"Получено: [{actual}] | {status}");
    }

    static void Main()
    {
        string[] inputs =
        {
            "",
            "   ",
            " a  b ",
            "А роза упала на лапу Азора",
            "Ахметов Ерлан"
        };

        int[] expectedWords = { 0, 0, 2, 6, 2 };
        bool[] expectedPalindrome = { true, true, false, true, false };
        string[] expectedInitials =
        {
            "", "", "A. B.", "А. Р. У. Н. Л. А.", "А. Е."
        };
        string[] expectedRepeat =
        {
            "", "      ", " a  b  a  b ",
            "А роза упала на лапу АзораА роза упала на лапу Азора",
            "Ахметов ЕрланАхметов Ерлан"
        };

        for (int i = 0; i < inputs.Length; i++)
        {
            Console.WriteLine($"\nТест {i + 1}: [{inputs[i]}]");

            Check("CountWords", inputs[i], expectedWords[i],
                TextTools.CountWords(inputs[i]));
            Check("IsPalindrome", inputs[i], expectedPalindrome[i],
                TextTools.IsPalindrome(inputs[i]));
            Check("Initials", inputs[i], expectedInitials[i],
                TextTools.Initials(inputs[i]));
            Check("Repeat", inputs[i], expectedRepeat[i],
                TextTools.Repeat(inputs[i], 2));
        }
    }
}
