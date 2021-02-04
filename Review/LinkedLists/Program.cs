using System;

namespace LinkedLists_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node(1);
            head.Next = new Node(2);

        }

        
    }

    //Add at Tail
    //Add at Head
    //GetValue at nth index
    //Get Len
    //Add at Index
    //Delete at Index
    //Reverse the list
    //Print the list
    class LinkedList
    {
        Node head;
        public static void PrintList(Node head)
        {

        }
    }
    
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node(int someVal)
        {
            Value = someVal;
            Next = null;
        }
    }
}
