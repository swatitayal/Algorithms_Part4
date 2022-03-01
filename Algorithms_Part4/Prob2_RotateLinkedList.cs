using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Part4
{
    class Prob2_RotateLinkedList
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList();
            myList.AddNode(10);
            myList.AddNode(20);
            myList.AddNode(30);
            myList.AddNode(40);
            myList.AddNode(50);
            myList.AddNode(60);
            myList.AddNode(70);
            
            int k = 4;

            Console.Write("\nThe elements of the Linked List are: ");
            myList.Print();

            rotateLL(myList, k);


        }
        static void rotateLL(LinkedList myList, int k)
        {
            Node curr_node = myList.Head;
            Node start, curr;
            
            int ctr = 0;
            while(curr_node!=null)
            {
                ctr++;
                if(ctr ==k)
                {
                    start = curr_node.next;
                    curr_node.next = null;
                    curr = start;
                    while(curr.next !=null)
                    {
                        curr = curr.next;
                    }
                    curr.next = myList.Head;
                    myList.Head = start;

                    Console.Write("The elements of the Linked List after rotation are: ");
                    myList.Print();

                    break;
                }

                else
                {
                    curr_node = curr_node.next;
                }
            }
        }
    }



    
}
