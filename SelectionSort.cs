using System;

class SelectionSort
{
    static void Main()
    {
        Console.Write("Enter array length:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int min = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("arr[{0}]=", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length - 1; i++)
        {
            min = i;
            for (int q = i + 1; q < arr.Length; q++)
            {
                if (arr[min] > arr[q]) min = q;
            }
            if (min != i)
            {
                int k = arr[i];
                arr[i] = arr[min];
                arr[min] = k;
            }

        }
        Console.WriteLine("Results:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}

