using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


//https://www.tutorialspoint.com/csharp/csharp_hashtable.htm
      //hash table is similar to array, except index number is caluculated using the vlaue itself
      //Hashing Algorithm >> calc applied to a key to transform it into and address (index value)
      ////example: if array values are strings
      ////// use ascii code for each letter, add them together and divide my length of array
      ////// for numeric keys - command to divice by the number of available addresses, and take remainder
      ////// for alphanumeric, divide the sum of ASCII codes in a key by # of available address, an take the remainder
      ////// folding method - divide thekey into equal parts and then add the parts togehter

      //// Collisions : two values return same address/location
      //// Load Factor - #items stored/size of array 
      // open addressing -better for low loadfactor
      //// Linear Probing - resovled by just moving down to the next available position/address
      ////// can lead to primary clustering - resolve with plus 3 rehash, quadratic probing, double hasing
      // closed addressing
      //// chaining - each index is a pointer to the 1st node of a linked list
      //// hash table of key-value pairs IS a hash map
      //https://www.youtube.com/watch?v=KyUTuwz_b7Q

namespace HashTables
{
    //Define data elements inside of hashtable

    public class Customer
    {
        public string Fname;
        public string Lname;
        public int Age;

        public Customer(string namefirst, string namelast, int age)
        {
            this.Fname = namefirst;
            this.Lname = namelast;
            this.Age = age;
        }
    }

    public class CustHashModel
    {
        private Hashtable _CustHash;
        public CustHashModel()
        {
            _CustHash = new Hashtable();
        }

        private static int custIdSeed = 0;

        //Methods
        public Hashtable AddCustomer(Customer newCust)
        {
            _CustHash.Add(custIdSeed, newCust);
            custIdSeed++;
            return _CustHash;
        }

        public void PrintHashTable()
        {
            foreach (var customer in _CustHash)
            {
                Console.WriteLine(customer.ToString());
            }

        }
       // Hash table methods: Put(), Remove(), Get(), Size()

      
    }

       
        

 }
    
