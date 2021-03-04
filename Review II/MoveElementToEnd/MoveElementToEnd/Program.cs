using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MoveElementToEnd
{
    class Program
    {
        // given an array of integers and an intger
        // write a function that moves all instances of that integer in the arry to the end of the array
        // return shifted array
        
        static void Main(string[] args)
        {
            List<int> array = new List<int> {2, 1, 2, 2, 2, 3, 4, 2};
            int toMove = 2;
            Console.WriteLine(  MoveElementToEnd(array, toMove));
            Console.WriteLine(  MoveElementToEndII(array, toMove));
        }
        public static List<int> MoveElementToEnd(List<int> array, int toMove)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            // Write your code here.
            int tmp = 0;
            for (int i = array.Count -1; i > -1; i--)
            {
                if (array[i] != toMove)
                {
                    tmp = array[i];
                    for (int j = i - 1; j > -1; j--)
                    {
                        if (array[j] == toMove)
                        {
                            array[i] = array[j];
                            array[j] = tmp;
                            break;
                        }
                    }
                }
               
                
            }
            timer.Stop();
            TimeSpan tspan = timer.Elapsed;
            Console.WriteLine(tspan);
            return array;
        }

        public static List<int> MoveElementToEndII(List<int> array, int toMove)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int i = 0;
            int j = array.Count - 1;
            while(i < j)
            {
                while (array[j] == toMove)
                {
                    j -= 1;
                }
                if (array[i] == toMove)
                {
                    var ind = Tuple.Create(array[i], array[j]);
                    array[i] = ind.Item2; array[j] = ind.Item1;
                }
                i += 1;
            }
            Console.WriteLine(timer);
            timer.Stop();
            TimeSpan tspan = timer.Elapsed;
            Console.WriteLine(tspan);
            return array;
        }

    }
}
// to move: 2
// array: [2, 1, 2, 2, 2, 3, 4, 4]
//output: [1, 3, 4, 2, 2, 2, 2, 2]

//start from the last index in array
//if current index is 'to move' value, do nothing
//if current index is NOT 'to move' value, set as temp
    //continue thru array until next 'to move' value is found
    //swap current indext with 'to move' value with tmp value
