using System;
using System.Drawing;

namespace linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList();
            myList.AddAtTail(7);  //0
            myList.AddAtHead(5); //1
            myList.AddAtTail(4); //2
            myList.AddAtTail(22);  //3
            Console.WriteLine(myList.GetLen());
            
            Console.WriteLine(myList.GetValue(3));
            Console.WriteLine(myList.GetValue(4));

            myList.AddAtIndex(2, 6);
            myList.Print();
            myList.DeleteAtIndex(1);
            myList.Print();
        }
    }

    class Node
    {
        public int Value {get; set;}
        public Node Next {get; set;}
        public Node(int someVal)
        {
            Value = someVal;
            Next = null;
        }
    }

    class LinkedList
    {
        Node head;

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            Node newNode = new Node(val);
            Node finger = head;

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                while (finger.Next != null)
                {
                    finger = finger.Next;
                }
                finger.Next = newNode;
            }
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            Node newNode = new Node(val);
            //Node finger = head;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                head = newNode;
                newNode.Next = temp;
            }
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int GetValue(int index)
        {
            Node pointer = head;
            if (index > (GetLen() - 1) || index < 0)
            {
                return -1;
            }
            else
            {
                for (int i = 0; i <= index; i++)
                {
                    if (i != index)
                    {
                        pointer = pointer.Next;
                    }
                }
            }
           return pointer.Value;
        }    

        public int GetLen()
        {
            int count = 1;
            Node pointer = head;
            if(pointer == null)
            {
                return 0;
            }
            else
            {
                while (pointer.Next != null)
                {
                    count++;
                    pointer = pointer.Next;
                }
            }
            return count;
        }
    
        /** Add a node of value val before the index n-th node in the linked list.
         If index equals to the length of linked list, the node will be appended to the end of linked list.
         If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val) 
        {
            Node newNode = new Node(val);
            Node pointer = head;
            if(index > GetLen())
            {
                Console.WriteLine("index is not valid");
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    pointer = pointer.Next;
                }
                Node temp = pointer.Next;
                pointer.Next = newNode;
                //AddAtTail();
                while (pointer.Next != null)
                {
                    pointer = pointer.Next;
                }
                pointer.Next = temp;
            }
        }
    
        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index) 
        {
            Node pointer = head;
            if (index > (GetLen() - 1) || index < 0)
            {
                Console.WriteLine("index is not valid");
            }
            else
            {
                for (int i = 0; i < index-1; i++)
                { 
                   pointer = pointer.Next;
                }
                Node temp = pointer.Next;
                temp = temp.Next;
                pointer.Next = temp;
            }
           

        }

        public void Reverse()
        {

        }

        // print the list
        public void Print()
        {
            Node pointer = head;
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.WriteLine();
                while (pointer != null)
                {
                    Console.Write(pointer.Value + ", ");
                    pointer = pointer.Next;
                }
                
            }
        }

    }
}
