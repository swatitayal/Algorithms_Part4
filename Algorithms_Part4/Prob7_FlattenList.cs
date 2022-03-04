using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Part4
{
    class Prob7_FlattenList
    {
        static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();
            
            myList.AddNode(5);
            myList.AddNode(10);
            myList.AddNode(19);
            myList.AddNode(28);
            myList.AddNode(55);
            myList.AddNode(75);
            myList.AddNode(80);

            myList.AddNodeToBottom(myList.Head, 7);
            myList.AddNodeToBottom(myList.Head, 8);
            myList.AddNodeToBottom(myList.Head, 30);

            myList.AddNodeToBottom(myList.Head.next, 20);

            myList.AddNodeToBottom(myList.Head.next.next, 22);
            myList.AddNodeToBottom(myList.Head.next.next, 50);

            myList.AddNodeToBottom(myList.Head.next.next.next, 35);
            myList.AddNodeToBottom(myList.Head.next.next.next, 40);
            myList.AddNodeToBottom(myList.Head.next.next.next, 45);

            Console.WriteLine("\nGiven List:");
            myList.print2DList();
            flattenList(myList.Head);

        }

        static void flattenList(Node<int> head)
        {
            Node<int> chead = head;
            Node<int> right = chead.next;
            Node<int> down = chead.bottom;
            LinkedList<int> result = new LinkedList<int>();
            LinkedList<int> leftOver = new LinkedList<int>();
            result.AddNode(head.data);

            while(right!=null && down!=null)
            {
                if(right.data > down.data)
                {
                    result.AddNode(down.data);
                    down = down.bottom;
                }
                else
                {
                    result.AddNode(right.data);
                    leftOver.Head = leftOver.AddNodeAsc(leftOver.Head, down.data);
                    chead = right;
                    right = chead.next;
                    down = chead.bottom;
                }
            }

            if (right == null)
            {
                while (down != null)
                {
                    leftOver.Head = leftOver.AddNodeAsc(leftOver.Head, down.data);
                    down = down.bottom;
                }
            }

            if (down == null)
            {
                while (right != null)
                {
                    leftOver.Head = leftOver.AddNodeAsc(leftOver.Head, right.data);
                    right = right.next;
                }
            }

            Console.WriteLine("\nPrinting result w/o merge:");
            result.Print();

            Console.WriteLine("\nLeft Over:");
            leftOver.Head.Print();

            Console.WriteLine("\nFinal Result after merge:");
            result.Head = Prob6_SortTwoLLs.sortLists(result.Head, leftOver.Head);
            result.Print();
            Console.WriteLine("\n");
        }
    }
}
