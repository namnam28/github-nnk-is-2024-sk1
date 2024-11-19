using System;

class Program
{
    // Function to implement Insertion Sort
    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;

        // Traverse through 1 to n-1 elements
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            // Move elements of arr[0..i-1] that are greater than key
            // to one position ahead of their current position
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }

            arr[j + 1] = key;
        }
    }

    // Helper function to print the array
    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // Example array to be sorted
        int[] arr = { 12, 11, 13, 5, 6 };

        Console.WriteLine("Original array:");
        PrintArray(arr);

        InsertionSort(arr);

        Console.WriteLine("Sorted array:");
        PrintArray(arr);
    }
}
