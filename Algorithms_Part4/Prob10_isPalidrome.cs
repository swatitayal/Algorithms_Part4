using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Part4
{
    class Prob10_isPalidrome
    {
        static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();

            myList.AddNode(1);
            myList.AddNode(2);
            myList.AddNode(3);
            //myList.AddNode(4);
            myList.AddNode(4);
            myList.AddNode(3);
            myList.AddNode(2);
            myList.AddNode(1);

            if (myList.Head == null)
            {
                Console.WriteLine("\nInvalid data! Input string can not be empty.");
            }

            else
            {
                Console.WriteLine("\nGiven List: ");
                myList.Print();

                bool result = isPalindrome(myList);

                if (result)
                {
                    Console.WriteLine("\nTRUE: Given list is a Palindrome\n");
                }
                else
                {
                    Console.WriteLine("\nFALSE: Given list is NOT a Palindrome \n");
                }
                
                myList.Print();
                Console.WriteLine("(List after Palindrome check)");
            }
        }


        static bool isPalindrome(LinkedList<int> input)
        {
            Node<int> fast = input.Head;
            Node<int> slow = input.Head;
            Node<int> curr = input.Head;
            Node<int> mid = null;                               //To store the value of mid point,
                                                                //will be used to reverse the list back to original.

            while (fast.next != null && fast.next.next != null) // Find the mid point of the linked list.
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            mid = slow;                                         //To store the value of mid point.
            slow.next = reverse(slow.next);

            slow = slow.next;

            while (slow != null)
            {
                if (slow.data == curr.data)
                {
                    slow = slow.next;
                    curr = curr.next;
                }
                else
                    break;
            }

            mid.next = reverse(mid.next);           //Reverse the half of the list back to original.

            if (slow == null)
                return true;
            else
                return false;
        }

        static Node<int> reverse(Node<int> head)
        {
            Node<int> curr = head;
            Node<int> tail = null;
            Node<int> prev = null;

            while(curr !=null)
            {
                tail = curr.next;
                curr.next = prev;
                prev = curr;
                curr = tail;
            }

            return prev;
        }


        //IsPalidrome implementation using a stack.
        static bool isPalindromeStack(LinkedList<char> input)
        {
            Node<char> fast = input.Head;
            Node<char> slow = input.Head;
            Stack<char> S = new Stack<char>();

            while(fast!= null && fast.next!= null) // Find the mid point of the linked list.
            {
                S.Push(slow.data);
                slow = slow.next;
                fast = fast.next.next;
            }

            if(fast!=null)                          //if list is odd numbered, move slow ptr to one node ahead.
            {
                slow = slow.next;
            }

            while (S.Count != 0 && slow!= null )
            {
                if (slow.data == S.Peek())
                {
                    slow = slow.next;
                    S.Pop();
                }
                else
                {
                    break;
                }
            }

            if (S.Count == 0 && slow == null)
                return true;
            else
                return false;

        }
    }
}
