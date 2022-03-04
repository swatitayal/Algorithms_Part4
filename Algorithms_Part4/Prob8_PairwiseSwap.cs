using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Part4
{
    class Prob8_PairwiseSwap
    {
        static void Main8(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();

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
                Node<int> result = swapPairwise(myList.Head);
                Console.WriteLine("\nList after pairwise swap: ");
                result.Print();
            }
            
        }

        static Node<int> swapPairwise(Node<int> head)
        {
            Node<int> key = head;
            Node<int> pair = null;
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
