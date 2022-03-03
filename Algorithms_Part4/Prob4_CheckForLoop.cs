using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Part4
{
    class Prob4_CheckForLoop
    {
        static void Main4(string[] args)
        {
            LinkedList myList = new LinkedList();

            for (int i = 1; i <= 5; i++)
            {
                myList.AddNode(i);
            }

            myList.Print();

            myList.AddLastNodeinLoop(2);
            //myList.Print();

            bool result = isLoop(myList.Head);

            if (result)
            {
                Console.WriteLine(result + ": The given List has a Loop.");
            }
            else
            {
                Console.WriteLine(result + ": The given List does NOT have a Loop.");
            }

        }

        static bool isLoop(Node head)
        {
            Node fast = head;
            Node slow = head;

            while(slow != null && fast!=null && fast.next!=null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if(slow == fast)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
