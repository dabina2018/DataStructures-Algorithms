using System;
using System.Collections;

public class Program
{
	public static void Main()
    {
		int[] array = { 3, 5, -4, 8, 11, 1, -1, 6 };
		int targetSum = 10;

       TwoNumberSum(array, targetSum);
    }
	public static int[] TwoNumberSum(int[] array, int targetSum)
	{
		int[] resultArray;
		Hashtable resultHash = new Hashtable();
		int m = 0;
		// Write your code here.
		for (int i = 0; i < array.Length; i++)
		{
			for (int j = (array.Length -1); j >0; j--)
            {
				if(i != j)
                {
					int num = array[i] + array[j];
					if (num == targetSum)
					{
						if (resultHash.ContainsValue(array[i]))
						{
							continue;
						}
						else
						{
							resultHash.Add(m, array[i]);
							resultHash.Add(m + 1, array[j]);
							m += 2;
						}
						
					}
				}
            }
		}
		
        foreach (DictionaryEntry entry in resultHash)
        {
            Console.Write("{0} ", entry.Value);
        }
		int arrayLen = resultHash.Count;
		resultArray = new int[arrayLen];
		resultHash.Values.CopyTo(resultArray, 0);
		return resultArray;
	}
}