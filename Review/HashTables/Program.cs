using System;
using System.Collections;
using HashTables;

namespace DSReview
{
    class Program
    {
        static void Main()
        {
            ////////////////////////////////////////////////////////////////////////////////
            //Defining some users
            Customer cust01 = new Customer("becky", "grande", 23);
            Customer cust02 = new Customer("Chrissy", "Maddison",55);
            CustHashModel custInfoHash = new CustHashModel();

            custInfoHash.AddCustomer(cust01);
            custInfoHash.AddCustomer(cust02);
            custInfoHash.PrintHashTable();
        }

        /*
         // Create user info hash
            Hashtable userInfoHash = new Hashtable()
            {
                {"001", "Zara Ali" },
                {"002", "Abida Rehman"},
                {"003", "Joe Holzner"},
                {"004", "Mausam Benazir Nur" },
                {"005", "M. Amlan" },
                {"006", "M. Arif"},
                {"007", "Ritesh Saika"}
            };

            //Add user Data
            userInfoHash.Add("001", "Zara Ali");
            userInfoHash.Add("002", "Abida Rehman");
            userInfoHash.Add("003", "Joe Holzner");
            userInfoHash.Add("004", "Mausam Benazir Nur");
            userInfoHash.Add("005", "M. Amlan");
            userInfoHash.Add("006", "M. Arif");
            userInfoHash.Add("007", "Ritesh Saika");


            //Loop thru Hash Table
            foreach (DictionaryEntry user in userInfoHash)
            {
                Console.WriteLine("key: "+ user.Key + "  userId: " + user.Value);
            }

            //Remove an entry
            userInfoHash.Remove("002");
            Console.WriteLine(userInfoHash.Contains("002"));
            Console.WriteLine(userInfoHash.ContainsValue("Abida Rehman"));
            Console.WriteLine(userInfoHash.ContainsKey("002"));
            Console.WriteLine("User 002 has been removed");


            //Update Hashtable
            userInfoHash["006"] = "Mary Poppins"; //update user name  value
            //string user006 = (string)userInfoHash["006"]; // cast entry to string
            Console.WriteLine(userInfoHash["006"]);

            if (!userInfoHash.ContainsKey("002"))
            { 
                userInfoHash["002"] = "Jean Grey"; 
            }

            foreach (DictionaryEntry user in userInfoHash)
            {
                //Console.WriteLine("key: " + user.Key + "userId" + user.Value);
                Console.WriteLine($"Key: {user.Key}, Value: {user.Value}");
            }

            userInfoHash.Contains("009"); */

    }

        
        
}

