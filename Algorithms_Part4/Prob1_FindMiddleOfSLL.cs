using System;

namespace Algorithms_Part4
{
    class Prob1_FindMiddleOfSLL
    {
        static void Main1(string[] args)
        {
            LinkedList myList = new LinkedList();
            myList.AddNode(1);
            myList.AddNode(2);
            myList.AddNode(3);
            myList.AddNode(4);
            myList.AddNode(5);
            myList.AddNode(6);

            myList.Print();

            FindMidNode(myList);
        }

        static void FindMidNode(LinkedList myList)
        {
            Node slow = myList.Head;
            Node fast = myList.Head;

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
