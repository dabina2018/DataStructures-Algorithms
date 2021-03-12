using System;
using System.Collections.Generic;
using System.Text;

namespace DesignHashMap
{
    public class MyData
    {
        public int MyKey { get; set; }
        public int MyValue { get; set; }

        public MyData(int key, int value)
        {
            MyKey = key;
            MyValue = value;
        }
    }

    public class MyHashMap
    {
        private const int HASH_MOD = 127;
        private LinkedList<MyData>[] store;

        /** Initialize your data structure here. */
        public MyHashMap()
        {
            store = new LinkedList<MyData>[HASH_MOD];
        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            int storeIndex = GetHashKey(key);
            if (store[storeIndex] == null)
            {
                store[storeIndex] = new LinkedList<MyData>();
            }

            var storeList = store[storeIndex];
            LinkedListNode<MyData> current = storeList.First;

            while ((current != null) && (current.Value.MyKey < key))
            {
                current = current.Next;
            }

            if ((current != null) && (current.Value.MyKey == key))
            {
                current.Value.MyValue = value;
                return;
            }

            var newData = new MyData(key, value);

            if (current == null)
            {
                storeList.AddLast(newData);
                return;
            }

            var newNode = new LinkedListNode<MyData>(newData);
            storeList.AddBefore(current, newData);

        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {

            int storeIndex = GetHashKey(key);

            if (store[storeIndex] == null)
            {
                return -1;
            }

            var storeList = store[storeIndex];
            var current = storeList.First;

            while ((current != null) && (current.Value.MyKey < key))
            {
                current = current.Next;
            }

            if ((current == null) || (current.Value.MyKey > key))
            {
                return -1;
            }

            return current.Value.MyValue;
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {

            int storeIndex = GetHashKey(key);

            if (store[storeIndex] == null)
            {
                return;
            }

            var storeList = store[storeIndex];
            var current = storeList.First;

            while ((current != null) && (current.Value.MyKey < key))
            {
                current = current.Next;
            }

            if ((current == null) || (current.Value.MyKey > key))
            {
                return;
            }

            storeList.Remove(current);

        }

        private static int GetHashKey(int key)
        {
            return key % HASH_MOD;
        }


    }
}
/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */