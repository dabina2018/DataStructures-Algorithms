using System;
using System.Collections.Generic;
using System.Text;

namespace DesignHashMap
{
    public class HashData
    {
        //Key-Value Pairs for each node in HashMap
        public int DataKey { get; set; }
        public int DataValue { get; set; }
        public HashData(int key, int value)
        {
            this.DataKey = key;
            this.DataValue = value;
        }
    }
    public class TutorialHashMap
    {
        //this value is the size of the hash array and the value used to find the Hash val
        private const int HashValue = 128;
        // hash map is an array of linked lists, LL nodes.Values = key-value pair
        private LinkedList<HashData>[] hashMap; 

        /** Initialize your data structure here. */
        public TutorialHashMap()
        {
            // instantiate new hashmap with a size of hash value
            hashMap = new LinkedList<HashData>[HashValue]; 
        }
        private static int GetHashKeyVal(int key)
        {
            // instantiate new hashmap with a size of hash value
            return key % HashValue;
        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            int hashMapIndex = GetHashKeyVal(key);
            if (hashMap[hashMapIndex] == null)
            {
                //if the key at the given index is null, create a new LL at that index
                hashMap[hashMapIndex] = new LinkedList<HashData>();
            }
            //set the fisrt node of the LL (current) EQUAL TO the corresponding index of the HashArray (hashMap[index])
            var hashIndexList = hashMap[hashMapIndex];
            LinkedListNode<HashData> current = hashIndexList.First;

            while (current != null && current.Value.DataKey < key)
            {   //traverse the hash array for as long as current key is less than given key
                current = current.Next; //
            }
            if (current != null && current.Value.DataKey == key)
            { // if the current bucket in hash array is not null and the key matches the input key
                current.Value.DataValue = value;// set current nodes value equal to input value
                return;
            }
            //create new KVpair(hashData) using input key and value
            var newData = new HashData(key, value);
            if (current == null)
            { //if the current hash array index/bucket is null, add data to bucket
                hashIndexList.AddLast(newData);
                return;
            }
            //create new linked list node using just created KVpair
            var newNode = new LinkedListNode<HashData>(newData);
            hashIndexList.AddBefore(current, newData);
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            return -1;

        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            
        }
        
    }

    /**
     * Your MyHashMap object will be instantiated and called as such:
     * MyHashMap obj = new MyHashMap();
     * obj.Put(key,value);
     * int param_2 = obj.Get(key);
     * obj.Remove(key);
     */
}
