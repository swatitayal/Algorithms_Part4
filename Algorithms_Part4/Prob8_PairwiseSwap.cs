using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Part4
{
    class Prob8_PairwiseSwap
    {
        static void Main8(string[] args)
        {
            LinkedList myList = new LinkedList();

            for (int i = 1; i <= 10; i++)
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
                Node result = swapPairwise(myList.Head);
                Console.WriteLine("\nList after pairwise swap: ");
                result.Print();
            }
            
        }

        static Node swapPairwise(Node head)
        {
            Node key = head;
            Node pair = null;
            int value = 0;

            while(key!= null && key.next!=null)
            {
                pair = key.next;
                value = key.data;
                key.data = pair.data;
                pair.data = value;
                key = key.next.next;
            }

            return head;
        }
    }
}
