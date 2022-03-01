using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Part4
{
    class Prob2_RotateLinkedList
    {
        static void Main2(string[] args)
        {
            LinkedList myList = new LinkedList();
            myList.AddNode(10);
            myList.AddNode(20);
            myList.AddNode(30);
            myList.AddNode(40);
            myList.AddNode(50);
            myList.AddNode(60);
            myList.AddNode(70);
            myList.AddNode(80);

            int k = 5;

            Console.Write("\nLinked List: ");
            myList.Print();

            rotateLL(myList, k);
        }
        static void rotateLL(LinkedList myList, int k)
        {
            Node curr_node = myList.Head;
            
            if (curr_node == null)
            {
                Console.Write("The List is empty!!\n");
                return;
            }

            int ctr = 1;

            while (curr_node != null && ctr < k)
            {
                ctr++;
                curr_node = curr_node.next;
            }

            Node last_node = curr_node;

            if(last_node.next == null)
            {
                Console.Write("The Linked List will be same after rotation by '" + k + "' nodes.\n");
                return;
            }

            while (curr_node.next != null)
            {
                curr_node = curr_node.next;
            }

            curr_node.next = myList.Head;
            myList.Head = last_node.next;
            last_node.next = null;

            Console.Write("The Linked List after rotation by '" + k + "' nodes is: ");
            myList.Print();
        }
    }
}
