using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCountdown
{
    class DataStructures
    {
        public static void ExArray(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            char[] arrayII = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k' };
        }
        public static void ExDictionary(int n)
        {
            Dictionary<int, string> alphabet = new Dictionary<int, string>();
            alphabet.Add(0, "apples");
            alphabet.Add(1, "berries");
            alphabet.Add(2, "canteloupe");
            alphabet.Add(3, "dasani");
            alphabet.Add(4, "eggo waffles");

            Dictionary<int, string> animals = new Dictionary<int, string>() { 
                { 0, "Alligator" }, { 1, "Bear" }, { 3, "Cat" }, { 4, "Dog" } };
        }
        public static void ExList(int n)
        {
            List<Array> listOfArray = new List<Array>();
            listOfArray.Add(new Array[1, 5, 5, 6]);
            listOfArray.Add(new Array[2]);
            listOfArray.Add(new Array[3, 5, 7]);
            listOfArray.Add(new Array[4, 5]);
            listOfArray.Add(new Array[5, 1]);

            List<Array> arrays = new List<Array>() { { new Array[4, 5] }, { new Array[5, 6,7, 5] }, { new Array[5] }};
        }

        public static void ExArrayList(int n)
        {
            ArrayList arrList = new ArrayList();
            arrList.Add(1);
            arrList.Add("Bill");
            arrList.Add(" ");
            arrList.Add(true);
            arrList.Add(4.5);
            arrList.Add(null);
            //Insert(int index, Object value)  // insert val at index
            arrList.Remove(true);
            arrList.RemoveAt(3);
        }
    }
    

}
