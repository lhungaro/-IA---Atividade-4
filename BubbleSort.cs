using System;

public class Program
{
    public static void Main()
    {
        int[] arr = { 64, 34, 25, 12, 22 };
        Console.WriteLine("Array original:");
		
		foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        BubbleSort(arr);

        Console.WriteLine("\nArray ordenado:");
		foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    swapped = true;
                }
            }
            n--;
        } while (swapped);
    }
}