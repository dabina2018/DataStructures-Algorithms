using System;
using System.Collections;
using System.Text;

namespace HashTable
{
    class HashTableClass
    {
        static Hashtable userInfoHash;
	
	//Basic Hash functions
        static void Main()
        {
            userInfoHash = new Hashtable();

            //Adding
            for(int i = 0; i < 10; i++)
            {
                userInfoHash.Add(i, "user" + i);
                //first parameter is key, value is string "user#"

            }

            //Removing
            if (userInfoHash.ContainsKey(0))
            {
                userInfoHash.Remove(0);
            }

            //Setting
            if (userInfoHash.ContainsKey(1))
            {
                userInfoHash[1] = "replacementName";
            }

            //Looping
            foreach (DictionaryEntry entry in userInfoHash)
            {
                Console.WriteLine("Key: " + entry.Key + " / Value: " + entry.Value);    
            }
        }

    }
}
