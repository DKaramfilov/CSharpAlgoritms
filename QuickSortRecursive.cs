using System;

class QuickSortRecursive
{
    static Random rand = new Random();
    static void Main()
    {
        int n = rand.Next(20, 30);
        int[] nums = new int[n];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.Next(100);
        }

        QuickSort(nums, 0, nums.Length - 1);
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }
    static void QuickSort(int[] s, int low, int high)
    {
        int p;

        if ((high - low) > 0)
        {
            p = Partition(s, low, high);
            QuickSort(s, low, p - 1);
            QuickSort(s, p + 1, high);
        }
    }
    static int Partition(int[] s, int low, int high)
    {
        int pivot, firstHigh;

        pivot = high;
        firstHigh = low;

        for (int i = low; i < high; i++)
        {
            if (s[i] < s[pivot])
            {
                int t = s[i];
                s[i] = s[firstHigh];
                s[firstHigh] = t;
                firstHigh++;
            }
        }
        int temp = s[pivot];
        s[pivot] = s[firstHigh];
        s[firstHigh] = temp;

        return firstHigh;
    }
}

