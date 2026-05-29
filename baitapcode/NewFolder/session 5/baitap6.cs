using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // =========================
        // PART 1: ARRAY FUNCTIONS
        // =========================

        int[] arr = GenerateRandomArray(10, 1, 20);

        Console.WriteLine("Random Array:");
        PrintArray(arr);

        Console.WriteLine("\nAverage: " + Average(arr));

        int searchValue = 5;
        Console.WriteLine($"\nContains {searchValue}? " + Contains(arr, searchValue));

        Console.WriteLine($"\nIndex of {searchValue}: " + IndexOf(arr, searchValue));

        Console.WriteLine("\nAfter removing value 5:");
        arr = RemoveElement(arr, 5);
        PrintArray(arr);

        Console.WriteLine("\nMin: " + Min(arr));
        Console.WriteLine("Max: " + Max(arr));

        Console.WriteLine("\nReversed array:");
        PrintArray(Reverse(arr));

        Console.WriteLine("\nDuplicates:");
        var dups = FindDuplicates(arr);
        Console.WriteLine(string.Join(", ", dups));

        Console.WriteLine("\nArray without duplicates:");
        PrintArray(RemoveDuplicates(arr));

        // =========================
        // PART 2
        // =========================

        Console.WriteLine("\n===== BUBBLE SORT =====");
        int[] userArr = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter integer {i + 1}: ");
            userArr[i] = int.Parse(Console.ReadLine());
        }

        BubbleSort(userArr);

        Console.WriteLine("Sorted array:");
        PrintArray(userArr);

        Console.WriteLine("\n===== LINEAR SEARCH =====");
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        Console.Write("Enter a word to search: ");
        string word = Console.ReadLine();

        bool found = LinearSearch(sentence, word);
        Console.WriteLine(found ? "Word found!" : "Word not found!");
    }

    // =========================
    // PART 1 FUNCTIONS
    // =========================

    static int[] GenerateRandomArray(int size, int min, int max)
    {
        Random rand = new Random();
        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
            arr[i] = rand.Next(min, max);

        return arr;
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }

    static double Average(int[] arr)
    {
        return arr.Average();
    }

    static bool Contains(int[] arr, int value)
    {
        return arr.Contains(value);
    }

    static int IndexOf(int[] arr, int value)
    {
        return Array.IndexOf(arr, value);
    }

    static int[] RemoveElement(int[] arr, int value)
    {
        return arr.Where(x => x != value).ToArray();
    }

    static int Min(int[] arr)
    {
        return arr.Min();
    }

    static int Max(int[] arr)
    {
        return arr.Max();
    }

    static int[] Reverse(int[] arr)
    {
        int[] reversed = (int[])arr.Clone();
        Array.Reverse(reversed);
        return reversed;
    }

    static List<int> FindDuplicates(int[] arr)
    {
        var seen = new HashSet<int>();
        var duplicates = new HashSet<int>();

        foreach (int x in arr)
        {
            if (!seen.Add(x))
                duplicates.Add(x);
        }

        return duplicates.ToList();
    }

    static int[] RemoveDuplicates(int[] arr)
    {
        return arr.Distinct().ToArray();
    }

    // =========================
    // PART 2 FUNCTIONS
    // =========================

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static bool LinearSearch(string sentence, string word)
    {
        string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string w in words)
        {
            if (w.Equals(word, StringComparison.OrdinalIgnoreCase))
                return true;
        }

        return false;
    }
}