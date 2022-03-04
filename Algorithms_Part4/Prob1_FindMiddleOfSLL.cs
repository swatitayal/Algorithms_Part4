using System;

namespace Algorithms_Part4
{
    class Prob1_FindMiddleOfSLL
    {
        static void Main1(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.AddNode(1);
            myList.AddNode(2);
            myList.AddNode(3);
            myList.AddNode(4);
            myList.AddNode(5);
            myList.AddNode(6);
            myList.AddNode(7);
            myList.AddNode(8);
            myList.AddNode(9);

            myList.Print();

            FindMidNode(myList);
        }

        static void FindMidNode(LinkedList<int> myList)
        {
            Node<int> slow = myList.Head;
            Node<int> fast = myList.Head;

            if (slow == null)
            {
                Console.WriteLine("\nThe List is empty!!");
                return;
            }
            else
            {
                while (fast != null && fast.next != null)
                {
                    slow = slow.next;
                    fast = fast.next.next;
                }
                Console.WriteLine("\nThe mid node is: " + slow.data);
            }
        }
    }
}
