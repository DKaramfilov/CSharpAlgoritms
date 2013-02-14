using System;

class Tasc11_BinarySearch
{
    static void Main()
    {
        Console.Write("Enter key to search:");
        int key = int.Parse(Console.ReadLine());

        Console.Write("Enter array length: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Element{0}=", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);

        int result = BinarySearch(key, arr);
        if (result > 0) Console.WriteLine("index of key{0} is {1}", key, result);
        else Console.WriteLine("Not Found");


    }
    public static int BinarySearch(int key, int[] a)
    {
        int lo = 0;
        int hi = a.Length - 1;
        while (lo <= hi)
        {
            int mid = lo + (hi - lo) / 2;
            if (key < a[mid]) hi = mid - 1;
            else if (key > a[mid]) lo = mid + 1;
            else return mid;
        }
        return -1;

    }
}

