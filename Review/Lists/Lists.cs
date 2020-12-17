using System;
using System.Collections.Generic;

namespace Lists
{
    class Lists
    {
        //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-5.0
        //https://www.geeksforgeeks.org/c-sharp-list-class/
        static void Main()
        {
            List<int> intList = new List<int>();
            Console.WriteLine(intList.Count);
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
           
            Console.WriteLine(intList[3]);
            Console.WriteLine("Capacity is:" + intList.Capacity);
            Console.WriteLine("Count is:" + intList.Count);

            intList.BinarySearch(12);
            intList.BinarySearch(1);

            intList.Contains(55);
            intList.Contains(2);

            intList.Remove(3);
            intList.RemoveAt(1);

            intList.Reverse();

            intList.Sort();

            intList.ToArray();
            intList.ToString();

        }
    }
}
