using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] nm = Console.ReadLine().Split(' ');
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int maxUnique = FindMaxUniqueIntegers(arr, m);
        Console.WriteLine(maxUnique);
    }

    static int FindMaxUniqueIntegers(int[] arr, int m)
    {
        int maxUnique = 0;
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        for (int i = 0; i < m; i++)
        {
            if (frequencyMap.ContainsKey(arr[i]))
                frequencyMap[arr[i]]++;
            else
                frequencyMap[arr[i]] = 1;
        }

        maxUnique = frequencyMap.Count;

        for (int i = m; i < arr.Length; i++)
        {
            if (frequencyMap[arr[i - m]] == 1)
                frequencyMap.Remove(arr[i - m]);
            else
                frequencyMap[arr[i - m]]--;

            if (frequencyMap.ContainsKey(arr[i]))
                frequencyMap[arr[i]]++;
            else
                frequencyMap[arr[i]] = 1;

            maxUnique = Math.Max(maxUnique, frequencyMap.Count);
        }

        return maxUnique;
    }
}
