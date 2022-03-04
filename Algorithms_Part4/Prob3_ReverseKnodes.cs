using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Part4
{
    class Prob3_ReverseKnodes
    {
        static void Main3(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();

            int k = 2;

            for (int i = 1; i <= 8; i++)
            {
                myList.AddNode(i);
            }

            if (myList.Head == null)
            {
                Console.WriteLine("List is empty!! ");
            }

            else
            {
                Console.WriteLine("Current List: ");
                myList.Print();
                Node<int> result = reverse(myList.Head, k);
                Console.WriteLine("\nList after reversing every '" + k + "' nodes: ");
                result.Print();
            }
        }

        static Node<int> reverse(Node<int> head, int k)
        {
            Node<int> curr = head;
            Node<int> tail = null;
            Node<int> prev = null;
            int ctr = 0;

            while(ctr<k && curr !=null)
            {
                tail = curr.next;
                curr.next = prev;
                prev = curr;
                curr = tail;
                ctr++;
            }

            if (tail != null)
            {
                head.next = reverse(curr, k);
            }
            
            return prev;
        }
    }
}
