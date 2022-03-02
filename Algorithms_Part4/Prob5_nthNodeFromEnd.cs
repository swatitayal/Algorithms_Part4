using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Part4
{
    class Prob5_nthNodeFromEnd
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList();
            int n = 3;

            for (int i = 1; i <= 8; i++)
            {
                myList.AddNode(i);
            }

            myList.Print();
            
            Node result = findNthNode(myList.Head, n);

            if (result != null)
            {
                Console.WriteLine(result.data);
            }
            
        }

        static Node findNthNode(Node head, int n)
        {
            Node pivot = head;
            Node curr_node = head;
            int ctr = 0;

            if (head == null)
            {
                Console.WriteLine("Invalid data: The List is empty!");
                return null;
            }

            if (n == 0)
            {
                Console.WriteLine("Invalid data!");
                return null;
            }

            while (ctr != n && pivot !=null)
            {
                pivot = pivot.next;
                ctr++;
            }

            if (ctr != n)
            {
                Console.WriteLine("Invalid data: The list does not have '" + n + "' nodes.");
                return null;
            }

           while (pivot != null)
           {
                pivot = pivot.next;
                curr_node = curr_node.next;
           }
               
           return curr_node;

        }
    }
}
