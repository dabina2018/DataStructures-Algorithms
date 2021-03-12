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
        //this value is the size of the hash array and the modulo value
        private const int HashValue = 128;
        // hash map is an array of linked lists
        private LinkedList<HashData>[] hashMap; 
                //each array index is the node of a linked list (calleda bucket)
                //each node consists of: int hash ~ K key/V value ~ Node<K,V> next





        /** Initialize your data structure here. */
        public TutorialHashMap()
        {
            // instantiate new hashmap (linked list array of type HashData with a size of hash value)
            hashMap = new LinkedList<HashData>[HashValue]; 
        }
        private static int GetHashKeyVal(int key)
        {
            // hash function
            return key % HashValue;
        }

        /** value will always be non-negative. */
        public void Put(int key, int value) //also updates
        {
            int hashMapIndex = GetHashKeyVal(key); //find hashmod of input key
            if (hashMap[hashMapIndex] == null)
            {
                //if the bucket/index of the input key is null, create new LL node at that index
                hashMap[hashMapIndex] = new LinkedList<HashData>();
                //Node == (hashVal,HashData)  || HashData == (Key, Value)
            }
            //set the tmp val current equal to the first node in the LL at the given bucket/index
            var hashIndexList = hashMap[hashMapIndex];
            LinkedListNode<HashData> current = hashIndexList.First;

            while (current != null && current.Value.DataKey < key)
            {   //traverse the LL at the current index for as long as current key is less than input key
                current = current.Next; 
            }
            if (current != null && current.Value.DataKey == key)
            { // if the node in the LL is not null and the key matches the input key
                current.Value.DataValue = value;// set current nodes value equal to input value (update)
                return;
            }
            //create new KVpair(hashData) using input key and value
            var newData = new HashData(key, value);
            if (current == null)
            { //if the current hash array index is null, add data to the bucket/index
                hashIndexList.AddLast(newData);
                return;
            }
            
            //create new linked list node using just created KVpair
            var newNode = new LinkedListNode<HashData>(newData);
            //add the node to the LL :: Node == (hashVal,HashData)  || HashData == (Key, Value)
            hashIndexList.AddBefore(current, newData);
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            int hashArrayInx = GetHashKeyVal(key);
            if (hashMap[hashArrayInx] == null)
            {
                return -1;
            }
            var indxLL = hashMap[hashArrayInx];
            var current = indxLL.First;
            
            while (current != null && current.Value.DataKey < key)
            {   //traverse the LL at the current index for as long as current key is less than input key
                current = current.Next;
            }
            if (current == null || current.Value.DataKey > key)
            {
                return -1;
            }
            return current.Value.DataValue;
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            int hashArrayIndx = GetHashKeyVal(key);
            if (hashMap[hashArrayIndx] == null)
            {
                return;
            }
            var indexLL = hashMap[hashArrayIndx];
            var current = indexLL.First;
            while (current != null && current.Value.DataKey < key)
            {
                current = current.Next;
            }
            if (current == null || current.Value.DataKey > key)
            {
                return;
            }
            indexLL.Remove(current);
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
