using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Part4
{
    public class LinkedList
    {
        public Node Head;
        public void AddNode(int data)
        {
            Node new_node = new Node(data);
            Node curr_node = Head;

            if (Head == null)
            {
                Head = new_node;
                Head.next = null;
            }
            else
            {
                while (curr_node.next != null)
                {
                    curr_node = curr_node.next;
                }
                curr_node.next = new_node;
            }
        }

        public void Print()
        {
            Node curr_node = Head;

            Console.Write("The elements of the Linked List are: ");
            while (curr_node != null)
            {
                Console.Write(curr_node.data + " ");
                curr_node = curr_node.next;
            }
        }
    }

    public class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}

