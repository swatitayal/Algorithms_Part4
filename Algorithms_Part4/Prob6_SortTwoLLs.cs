using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Part4
{
    class Prob6_SortTwoLLs
    {
        static void Main6(string[] args)
        {
            LinkedList<int> listA = new LinkedList<int>();
            LinkedList<int> listB = new LinkedList<int>();
            //listA.AddNode(10);
            //listA.AddNode(20);
            //listA.AddNode(30);
            //istB.AddNode(15);
            //listB.AddNode(17);

            listA.AddNode(5);
            listA.AddNode(7);
            listA.AddNode(9);
            listB.AddNode(4);
            listB.AddNode(6);
            listB.AddNode(8);

            //listA.AddNode(1);
            //listA.AddNode(3);
            //listA.AddNode(5);
            //listA.AddNode(7);
            //listB.AddNode(2);
            //listB.AddNode(4);

            //listB.AddNode(10);
            //listA.AddNode(20);
            //listA.AddNode(30);
            //listB.AddNode(15);
            //listB.AddNode(17);

            listA.Print();
            listB.Print();

            Node<int> result = sortLists(listA.Head, listB.Head);

            if (result != null)
            {
                result.Print();
            }
            else
            {
                Console.WriteLine("Both lists are empty!");
            }
                
        }

        public static Node<int> sortLists(Node<int> headA, Node<int> headB)
        {
            Node<int> cA = headA;
            Node<int> cB = headB;
            
            Node<int> done = null;
            Node<int> temp = null;

            if(cA == null && cB == null)                //If both lists are empty
            {
                return null;
            }
            else if(cA == null && cB !=null)            //If ListA is empty
            {
                headA = headB;
                return headA;
            }
            else if(cA != null && cB == null)           //If ListB is empty
            {
                return headA;
            }

            if (cA.data < cB.data)                      //Compare the head of both lists
            {
                done = cA;
                cA = cA.next;
            }
            else
            {
                temp = cB;
                cB = cB.next;
                temp.next = headA;
                headA = temp;
                done = temp;
            }

            while(cA != null && cB != null)          //Sorting of the lists
            {
                if(cA.data < cB.data)
                {
                    done = cA;
                    cA = cA.next;
                }

                else
                {
                    temp = cB;
                    cB = cB.next;
                    temp.next = done.next;
                    done.next = temp;
                    done = done.next;
                }
            }

            if(cA == null)                      //leftover nodes
            {
                done.next = cB;
            }
            else
            {
                done.next = cA;
            }

            return headA;
            
        }
    }
}
