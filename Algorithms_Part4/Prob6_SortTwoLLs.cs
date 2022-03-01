using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Part4
{
    class Prob6_SortTwoLLs
    {
        static void Main(string[] args)
        {
            LinkedList listA = new LinkedList();
            LinkedList listB = new LinkedList();
            //listA.AddNode(10);
            //listA.AddNode(20);
            //listA.AddNode(30);
            //listB.AddNode(15);
            //listB.AddNode(17);

            //listA.AddNode(5);
            //listA.AddNode(7);
            //listA.AddNode(9);
            //listB.AddNode(4);
            //listB.AddNode(6);
            //listB.AddNode(8);

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

            listA = sortLists(listA, listB);

            if (listA != null)
            {
                listA.Print();
            }
            else
            {
                Console.WriteLine("Both lists are empty!");
            }
                
        }

        static LinkedList sortLists(LinkedList listA, LinkedList listB)
        {
            Node cA = listA.Head;
            Node cB = listB.Head;
            
            Node done = null;

            if(cA == null && cB == null)                //If both lists are empty
            {
                return null;
            }
            else if(cA == null && cB !=null)            //If ListA is empty
            {
                return listB;
            }
            else if(cA != null && cB == null)           //If ListB is empty
            {
                return listA;
            }

            if (cA.data < cB.data)                      //Compare the head of both lists
            {
                done = cA;
                cA = cA.next;
            }
            else
            {
                Node temp = cB;
                cB = cB.next;
                temp.next = listA.Head;
                listA.Head = temp;
                done = temp;
            }

            while(cA != null & cB != null)          //Sorting of the lists
            {
                if(cA.data < cB.data)
                {
                    done = cA;
                    cA = cA.next;
                }

                else
                {
                    Node temp = cB;
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

            return listA;
            
        }
    }
}
