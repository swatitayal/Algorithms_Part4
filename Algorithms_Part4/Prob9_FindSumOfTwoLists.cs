using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Part4
{
    class Prob9_FindSumOfTwoLists
    {
        static void Main(string[] args)
        {
            LinkedList listA = new LinkedList();
            LinkedList listB = new LinkedList();

            //listA.AddNode(5);
            //listA.AddNode(4);

            //listB.AddNode(5);
            //listB.AddNode(4);
            //listB.AddNode(3);

            listA.AddNode(5);
            listA.AddNode(5);

            listB.AddNode(5);
            listB.AddNode(5);
            listB.AddNode(9);
            listB.AddNode(9);

            listA.Print();
            listB.Print();

            LinkedList sum = findSum(listA, listB);
            if (sum.Head == null)
            {
                Console.WriteLine("The lists are empty!");
            }

            else
            {
                sum.Print();
            }

        }
        
        static LinkedList findSum(LinkedList listA, LinkedList listB)
        {
            Node ca = listA.Head;
            Node cb = listB.Head;

            LinkedList sumList = new LinkedList();
            int result = 0;
            int carry = 0;

            while(ca!= null || cb != null)
            {
                if (ca == null)
                {
                    result = cb.data + carry;
                    cb = cb.next;
                }

                else if (cb == null)
                {
                    result = ca.data + carry;
                    ca = ca.next;
                }

                else
                {
                    result = ca.data + cb.data + carry;
                    ca = ca.next;
                    cb = cb.next;
                }

                if(result >=10)
                {
                    sumList.AddNode(result - 10);
                    carry = 1;
                }
                else
                {
                    sumList.AddNode(result);
                    carry = 0;
                }
            }

            if(carry == 1)
            {
                sumList.AddNode(carry);
            }


            return sumList;
        }
    }
}
