using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCountdown
{
    class HashItUp
    {
        static public void ExHashStuff(int n, int[] array)
        {
            HashSet<int> hs = new HashSet<int>(array);
            
            Hashtable ht = new Hashtable();
            for (int i = 0; i < 100; i++)
            {
                ht.Add(i, 'a');
            }

            Dictionary<char, int> hp = new Dictionary<char, int>() {
                {'a', 0 }, {'b', 0 }, {'c', 0 }, {'d', 0 }, {'e', 0 }, {'f', 0 } };

        }
        public class HashData
        {
            public int DataKey { get; set; }
            public int DataValue { get; set; }
            public HashData(int key, int value)
            {
                this.DataKey = key;
                this.DataValue = value;
            }
        }
        public class HashMap
        {
            private const int HashValue = 256;
            private LinkedList<HashData>[] hashMap; // an array of LL
            public HashMap()
            {
                hashMap = new LinkedList<HashData>[HashValue]; // set length of array = hashvalue
            }
            private static int GetHashIndexVal(int key)
            {
                // get hash index of input
                return key % HashValue;
            }
            //------------------Put --------------------//
            public  void Put(int key, int value)
            {
                int hashMapIndex = GetHashIndexVal(key);
                  
            }
            

        }
    }
}
