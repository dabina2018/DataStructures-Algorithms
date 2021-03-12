using System;
using System.Collections.Generic;

namespace DesignHashMap
{
    class Program
    {
        //Design a HashMap without using any built-in hash table libraries.
        //Implement the MyHashMap class:
        //MyHashMap() initializes the object with an empty map.
        //void put(int key, int value) inserts a(key, value) pair into the HashMap.
        //      If the key already exists in the map, update the corresponding value.
        //int get(int key) returns the value to which the specified key is mapped,
        //      or -1 if this map contains no mapping for the key.
        //void remove(key) removes the key and its corresponding value if the map contains the mapping for the key.
        static void Main()
        {
            MyHashMap myHashMap = new MyHashMap();
            myHashMap.put(1, 1); // The map is now [[1,1]]
            myHashMap.put(2, 2); // The map is now [[1,1], [2,2]]
            Console.WriteLine(myHashMap.get(1));    // return 1, The map is now [[1,1], [2,2]]
            Console.WriteLine(myHashMap.get(3));    // return -1 (i.e., not found), The map is now [[1,1], [2,2]]
            myHashMap.put(2, 1); // The map is now [[1,1], [2,1]] (i.e., update the existing value)
            Console.WriteLine(myHashMap.get(2));    // return 1, The map is now [[1,1], [2,1]]
            myHashMap.remove(2); // remove the mapping for 2, The map is now [[1,1]]
            Console.WriteLine(myHashMap.get(2));    // return -1 (i.e., not found), The map is now [[1,1]]
        }
     
        //public Dictionary hashmap = new DictionaryBase();
       
        public class MyHashMap
        {
            private Dictionary<int, int> hashmap;
            public MyHashMap()
            {
                hashmap = new Dictionary<int, int>();
            }
            
            public void put(int key, int value)
            {
                if (hashmap.ContainsKey(key))
                {
                    hashmap[key] = value;
                }
                else
                {
                    hashmap.Add(key, value);
                }
            }
            public int get(int key)
            {
                if (hashmap.ContainsKey(key))
                {
                   hashmap.TryGetValue(key, out int value);
                    return value;
                }
                else
                {
                    return -1;
                }
                
            }
            public void remove(int key)
            {
                if (hashmap.ContainsKey(key))
                {
                    hashmap.Remove(key);
                }
               
            }
        }
    }
}
