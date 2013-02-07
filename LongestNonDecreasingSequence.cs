using System;
class tasc18
{
    static void Main()
    {
        int[] array = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
        int len = array.Length;
        int[] dp = new int[len];
        int[] index = new int[len];

        dp[0] = 1;
        index[0] = -1;
        int maxLength = 1, bestEnd = 0;

        for (int i = 1; i < len; i++)
        {
            dp[i] = 1;
            index[i] = -1;
            for (int j = 0; j < i; j++)
            {
                if (array[i] >= array[j])
                {
                    if (dp[i] < dp[j] + 1)
                    {
                        dp[i] = dp[j] + 1;
                        index[i] = j;

                    }
                }
            }
            if (dp[i] > maxLength)
            {
                bestEnd = i;
                maxLength = dp[i];
            }
        }
        string temp = "";
        for (int k = bestEnd; k >= 0; k = index[k])
        {
            temp = array[k].ToString()+" " + temp;
            
        }
        Console.WriteLine(temp);

    }
}



