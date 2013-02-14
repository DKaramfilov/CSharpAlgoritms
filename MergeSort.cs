using System;

class MergeSortRecursive
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

        MergeSort(nums, 0, nums.Length - 1);
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }
    static public void MergeSort(int[] s, int low, int high)
    {
        int middle;

        if (low < high)
        {
            middle = (low + high) / 2;
            MergeSort(s, low, middle);
            MergeSort(s, middle + 1, high);
            Merge(s, low, middle + 1, high);
        }
    }
    static public void Merge(int[] s, int low, int middle, int high)
    {
        int leftEnd, numElelments, tempPos;
        int[] temp = new int[s.Length];

        leftEnd = middle - 1;
        tempPos = low;
        numElelments = high - low + 1;

        while ((low <= leftEnd) && (middle <= high))
        {
            if (s[low] <= s[middle])
            {
                temp[tempPos] = s[low];
                tempPos++;
                low++;
            }
            else
            {
                temp[tempPos] = s[middle];
                tempPos++;
                middle++;
            }
        }
        while (low <= leftEnd)
        {
            temp[tempPos] = s[low];
            tempPos++;
            low++;
        }
        while (middle <= high)
        {
            temp[tempPos] = s[middle];
            tempPos++;
            middle++;
        }
        for (int i = 0; i < numElelments; i++)
        {
            s[high] = temp[high];
            high--;
        }
    }
}



