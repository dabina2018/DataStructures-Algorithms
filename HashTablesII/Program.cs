using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
//https://www.youtube.com/watch?v=s8YcbwVl-HI

namespace HashTablesII
{
    //testing efficency of Access
    //create struct for custm list type
    struct UserInfo
    {
        public int userId;
        public string userName;
        public UserInfo(int id, string name)
        {
            userId = id;
            userName = name;
        }
    }
    
    class HashTableClass
    {
        static Hashtable userInfoHash;
        static List<UserInfo> userInfoList;
        static Stopwatch sw;
        
        //prove efficieny of Hash over list
        static void Main()
        {
            userInfoHash = new Hashtable();
            userInfoList = new List<UserInfo>();
            sw = new Stopwatch();
            //Adding
            for (int i = 0; i < 10; i++)
            {
                userInfoHash.Add(i, "user" + i);
                //first parameter is key, value is string "user#"
                userInfoList.Add(new UserInfo(i, "user" + i));
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

            /*
             Looping
            foreach (DictionaryEntry entry in userInfoHash)
            {
                Console.WriteLine("Key: " + entry.Key + " / Value: " + entry.Value);
            }
            */

            //Access
            Random randomUserGen = new Random();
            int randomUser = -1;

            sw.Start();
            float startTime = 0;
            float endTime = 0;
            float deltaTime = 0;

            int cycles = 5;
            int cycle = 0;
            string userName = string.Empty;

            while (cycle < cycles)
            {
                randomUser = randomUserGen.Next(3000000, 4000000);

                startTime = sw.ElapsedMilliseconds;

                //ACCESS FROM LIST
                userName = GetUserFromList(randomUser);
                endTime = sw.ElapsedMilliseconds;
                deltaTime = endTime - startTime;
                Console.WriteLine("Time taken to retrieve " + userName+ " from list took" + string.Format("{0:0.##}", deltaTime) + "ms");

                startTime = sw.ElapsedMilliseconds;

                //ACCESS FROM HASHTABLE
                userName = (string)userInfoHash[randomUser];
                endTime = sw.ElapsedMilliseconds;
                deltaTime = endTime - startTime;
                Console.WriteLine("Time taken to retrieve " + userName + " from hash took " + string.Format("{0:0.##}", deltaTime) + "ms");

                cycle++;
            }
        }

        //acessing from list requires an external method
        static string GetUserFromList(int userId)
        {
            for (int i = 0; i < userInfoList.Count; i++)
            {
                return userInfoList[i].userName;
            }
            return string.Empty;
        }

    }
}
